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
    
    public partial class Fournisseur
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Fournisseur()
        {
            this.Bon_Livraison = new HashSet<Bon_Livraison>();
            this.Mvt_Stock = new HashSet<Mvt_Stock>();
        }
    
        public int frns_Code { get; set; }
        public string frns_Nom { get; set; }
        public string frns_Adresse { get; set; }
        public string frns_Adresse2 { get; set; }
        public string frns_Code_Postal { get; set; }
        public string frns_Ville { get; set; }
        public string frns_Email { get; set; }
        public string frns_GSM { get; set; }
        public string frns_GSM2 { get; set; }
        public string frns_Fixe1 { get; set; }
        public string frns_Fixe2 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bon_Livraison> Bon_Livraison { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mvt_Stock> Mvt_Stock { get; set; }
    }
}