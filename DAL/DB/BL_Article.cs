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
    
    public partial class BL_Article
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BL_Article()
        {
            this.Mvt_Stock = new HashSet<Mvt_Stock>();
        }
    
        public int bl_A_Code { get; set; }
        public Nullable<System.DateTime> bl_A_Date { get; set; }
        public Nullable<int> bl_Code { get; set; }
        public Nullable<int> art_Code { get; set; }
        public Nullable<int> ref_Code { get; set; }
        public Nullable<int> cb_Code { get; set; }
    
        public virtual Article Article { get; set; }
        public virtual Bon_Livraison Bon_Livraison { get; set; }
        public virtual CodeBarre CodeBarre { get; set; }
        public virtual Reference Reference { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mvt_Stock> Mvt_Stock { get; set; }
    }
}