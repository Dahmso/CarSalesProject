using CarSalesData;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarSalesProject.ViewModels
{
    public class LocationViewModel
    {
        [Required(ErrorMessage = "Le véhicule doit être renseigné")]
        [Display(Name = "Véhicule")]
        public List<Vehicule> Vehicule { get; set; }

        [Required(ErrorMessage = "Le commercial doit être renseigné")]
        [Display(Name = "Commercial")]
        public List<Personne> Commercial { get; set; }

        [Required(ErrorMessage = "Le client doit être renseigné")]
        [Display(Name = "Client")]
        public List<Personne> Client { get; set; }

        [Required(ErrorMessage = "Le contrat de location doit être complété")]
        [Display(Name = "Location")]
        public Location Location { get; set; }
    }
}