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
    
    public partial class Emplacement
    {
        public int eplc_Code { get; set; }
        public Nullable<System.DateTime> eplc_Date { get; set; }
        public Nullable<int> ref_Code { get; set; }
        public Nullable<int> rayo_Code { get; set; }
        public Nullable<int> etgr_Code { get; set; }
        public Nullable<int> mags_Code { get; set; }
    
        public virtual Etager Etager { get; set; }
        public virtual Magasin Magasin { get; set; }
        public virtual Rayonnage Rayonnage { get; set; }
        public virtual Reference Reference { get; set; }
    }
}
