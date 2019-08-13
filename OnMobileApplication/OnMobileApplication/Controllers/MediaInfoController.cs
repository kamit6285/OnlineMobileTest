using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnMobileContainer;
using OnMobileApplication.Models;

namespace OnMobileApplication.Controllers
{
    public class MediaInfoController : Controller
    {
        OnMobileTestEntities contextObj = new OnMobileTestEntities();
        // GET: MediaInfo
        public ActionResult GallaryDetails()
        {
            List<ListSearchModel> modelListObj = new List<ListSearchModel>();
            var list1 = from x in contextObj.tblContentGallaries
                        join y in contextObj.tblGallaries on x.gallaryId equals y.gallaryId into temp
                        from xx in temp.DefaultIfEmpty()
                        select new { GallaryName = xx.gallaryName, Count = x.gallaryId, ContentId = x.contentId };
           

            //var list3 = from x in contextObj.tblContentGallaries
            //    join y in contextObj.tblGallaries on x.contentId equals null
            //    select new { GallaryName = y.gallaryName, Count = x.gallaryId, ContentId = x.contentId };


            var list2 = list1.GroupBy(x => x.GallaryName).ToDictionary(x => x, x =>x.Count());
                                                
            foreach(var item in list2)
            {
                modelListObj.Add(new ListSearchModel() { GallaryName = item.Key.Key, Count = item.Value});
            }

            return View(modelListObj);
        }
        
    }
}