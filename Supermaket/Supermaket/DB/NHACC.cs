//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Supermaket.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class NHACC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHACC()
        {
            this.PHIEUNHAPs = new HashSet<PHIEUNHAP>();
        }
    
        public string MANCC { get; set; }
        public string TENNCC { get; set; }
        public string DIACHINCC { get; set; }
        public string SDTNCC { get; set; }
        public string SOTAIKHOANNCC { get; set; }
        public string MASOTHUENCC { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUNHAP> PHIEUNHAPs { get; set; }
    }
}
