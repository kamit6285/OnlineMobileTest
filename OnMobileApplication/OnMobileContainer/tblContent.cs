//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnMobileContainer
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblContent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblContent()
        {
            this.tblContentGallaries = new HashSet<tblContentGallary>();
        }
    
        public int contentId { get; set; }
        public string bookName { get; set; }
        public string bookAuthorName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblContentGallary> tblContentGallaries { get; set; }
    }
}
