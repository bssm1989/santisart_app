//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace testLogin.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ClassInSchool
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ClassInSchool()
        {
            this.EnrollCouse = new HashSet<EnrollCouse>();
        }
    
        public string ClassShortName { get; set; }
        public string ClassName { get; set; }
        public int ClassID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EnrollCouse> EnrollCouse { get; set; }
    }
}
