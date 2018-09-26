using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarSalesData;
using CarSalesData.Helpers;

namespace CarSalesProject.ViewModels
{
    public class VehiculeViewModel
    {
        public Vehicule Vehicule { get; set; }

        public VehiculeOccasion VehiculeOccasion { get; set; }

        [Required(ErrorMessage = "Le type du véhicule doit être renseigné")]
        [Display(Name = "Statut")]
        public List<SelectListItem> StatutsVehicule { get; set; }

        [Required(ErrorMessage = "La couleur doit être renseignée")]
        [Display(Name = "Couleur")]
        public List<SelectListItem> CouleursVehicule { get; set; }

        [Required(ErrorMessage = "La marque du véhicule doit être renseigné")]
        [Display(Name = "Marque")]
        public List<ConstructeursVoiture> Marques { get; set; }

        public string Statut { get; set; }
    }
}