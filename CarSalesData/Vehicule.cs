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
    
    public partial class Vehicule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vehicule()
        {
            this.ContratAchat = new HashSet<ContratAchat>();
            this.Location = new HashSet<Location>();
            this.Operation = new HashSet<Operation>();
            this.Plein = new HashSet<Plein>();
            this.VehiculeOccasion = new HashSet<VehiculeOccasion>();
        }
    
        public int Id { get; set; }
        public string Immatriculation { get; set; }
        public Nullable<int> IdProprietaire { get; set; }
        public string Marque { get; set; }
        public int Puissance { get; set; }
        public string Couleur { get; set; }
        public string Modele { get; set; }
        public int Kilometrage { get; set; }
        public decimal PrixAchat { get; set; }
        public Nullable<decimal> PrixVente { get; set; }
        public System.DateTime DateAchat { get; set; }
        public Nullable<System.DateTime> DateVente { get; set; }
    
        public virtual ConstructeursVoiture ConstructeursVoiture { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContratAchat> ContratAchat { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Location> Location { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Operation> Operation { get; set; }
        public virtual Personne Personne { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Plein> Plein { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VehiculeOccasion> VehiculeOccasion { get; set; }
    }
}
