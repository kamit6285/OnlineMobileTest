using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OnMobileContainer;
using OnMobileApplication.Models;

namespace OnMobileApplication.Controllers
{
    [RoutePrefix("api/OnMobileServiceAPI")]
    public class OnMobileServiceAPIController : ApiController
    {
        OnMobileTestEntities context = new OnMobileTestEntities();
        [HttpGet]
        [Route(""), ActionName("GetDetailsByMultipleIdSeparatedWithSlash")]
        // GET: api/OnMobileServiceAPI
        public List<DetailSearchModel> Get([FromUri] string gallaryNamePara)
        {
            List<DetailSearchModel> l1 = new List<DetailSearchModel>();

            IEnumerable<int> GallaryId = context.tblGallaries.Where(x => x.gallaryName.ToUpper() == gallaryNamePara.ToUpper()).Select(x=>x.gallaryId);            
            var contentIdList =context.tblContentGallaries.Where(x => x.gallaryId == GallaryId.FirstOrDefault()).Select(x => x.contentId);
            if (contentIdList.Where(x=>x.Value>0).Count()>0)
            {
                foreach (int i in contentIdList)
                {
                    l1.Add(new DetailSearchModel()
                    {
                        GallaryName = gallaryNamePara,
                        BookName = context.tblContents.FirstOrDefault(x => x.contentId == i).bookName,
                        AuthorName = context.tblContents.FirstOrDefault(x => x.contentId == i).bookAuthorName,
                        GallaryDescription=context.tblGallaries.FirstOrDefault(x => x.gallaryName.ToUpper() == gallaryNamePara.ToUpper()).gallaryDescription
                    });
                }
            }
            else
            {
                l1 = null;
            }
           
            return l1;
        }
        
    }
}
