//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarSalesData
{
    using System;
    using System.Collections.Generic;
    
    public partial class Plein
    {
        public int Id { get; set; }
        public int IdFournisseur { get; set; }
        public int IdVehicule { get; set; }
        public System.DateTime DatePlein { get; set; }
        public decimal Volume { get; set; }
        public decimal PrixLitre { get; set; }
        public int Kilometrage { get; set; }
    
        public virtual Professionnel Professionnel { get; set; }
        public virtual Vehicule Vehicule { get; set; }
    }
}
