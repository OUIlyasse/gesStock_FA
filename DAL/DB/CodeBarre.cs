//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class CodeBarre
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CodeBarre()
        {
            this.BL_Article = new HashSet<BL_Article>();
        }
    
        public int cb_code { get; set; }
        public Nullable<System.DateTime> cb_Date { get; set; }
        public string cb_Designation { get; set; }
        public Nullable<int> ref_Code { get; set; }
        public Nullable<int> typ_Code { get; set; }
        public Nullable<bool> cb_Status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BL_Article> BL_Article { get; set; }
        public virtual Operation_Type Operation_Type { get; set; }
        public virtual Reference Reference { get; set; }
    }
}
