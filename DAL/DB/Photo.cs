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
    
    public partial class Photo
    {
        public int pho_Code { get; set; }
        public string pho_Path { get; set; }
        public string pho_Nom { get; set; }
        public Nullable<int> art_Code { get; set; }
    
        public virtual Article Article { get; set; }
    }
}