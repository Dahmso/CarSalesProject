using CarSalesData;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarSalesProject.ViewModels
{
    public class GestionVehiculeViewModel
    {
        public Vehicule vehicule { get; set; }

        [Display(Name = "Liste véhicules neufs")]
        public List<Vehicule> Vehicules { get; set; }

        [Display(Name = "Statut")]
        public List<SelectListItem> StatutsVehicule { get; set; }
    }
}