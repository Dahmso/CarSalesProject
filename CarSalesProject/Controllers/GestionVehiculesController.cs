using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using CarSalesData;
using CarSalesData.Helpers;
using CarSalesProject.ViewModels;

namespace CarSalesProject.Controllers
{
    public class GestionVehiculesController : Controller
    {
        #region Methods for the GestionVehicules view
        public ActionResult Index()
        {
            List<Vehicule> vehicules = VehiculeHelper.Current.GetList();

            GestionVehiculeViewModel vvm = new GestionVehiculeViewModel()
            {
                Vehicules = vehicules,
                StatutsVehicule = new List<SelectListItem>
                {
                    new SelectListItem { Value = "0", Text = "Occasion"},
                    new SelectListItem { Value = "1", Text = "Neuf"}
                }
            };

            return View("Index", vvm);
        }

        [HttpPost]
        public ActionResult Ajouter(Vehicule vehicule)
        {
            if (!ModelState.IsValid)
            {
                return Index();
            }

            return RedirectToAction("AjoutVehicule", "GestionVehicules");
        }

        [HttpPost]
        public ActionResult Transferer(Vehicule vehicule)
        {
            if (!ModelState.IsValid)
            {
                return Index();
            }

            return RedirectToAction("Index", "AjoutVehicule");
        }

        [HttpPost]
        public ActionResult Modifier(Vehicule vehicule)
        {
            if (!ModelState.IsValid)
            {
                return Index();
            }

            return RedirectToAction("Index", "AjoutVehicule");
        }

        [HttpPost]
        public ActionResult Supprimer(Vehicule vehicule)
        {
            if (!ModelState.IsValid)
            {
                return Index();
            }

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public ActionResult Retour()
        {
            if (!ModelState.IsValid)
            {
                return Index();
            }

            return RedirectToAction("Index", "Home");
        }

        #endregion

        #region Methods for the AjoutVehicule view
        public ActionResult AjoutVehicule()
        {
            List<ConstructeursVoiture> marques = ConstructeursVoitureHelper.Current.GetList();

            VehiculeViewModel vvm = new VehiculeViewModel()
            {
                Vehicule = new Vehicule(),
                VehiculeOccasion = new VehiculeOccasion(),
                StatutsVehicule = new List<SelectListItem>
                {
                    new SelectListItem { Value = "0", Text = "Neuf"},
                    new SelectListItem { Value = "1", Text = "Occasion"}
                },
                CouleursVehicule = GetAllColors(),
                Marques = marques,
                Statut = ""
            };

            return View("AjoutVehicule", vvm);
        }

        [HttpPost]
        public ActionResult ValiderAjtVehicule(Vehicule vehicule, VehiculeOccasion vehiculeOccasion, string statut)
        {   /*
            if (!ModelState.IsValid)
            { 
                return Index();
            }*/

            VehiculeHelper.Current.Insert(vehicule);

            if (statut == "1")
            {
                vehiculeOccasion.IdVehicule = vehicule.Id;
                VehiculeOccasionHelper.Current.Insert(vehiculeOccasion);
            }

            return RedirectToAction("Index", "GestionVehicules");
        }

        [HttpPost]
        public ActionResult RetourAjtVehicule(Vehicule vehicule)
        {
            return RedirectToAction("Index", "GestionVehicules");
        }

        public List<SelectListItem> GetAllColors()
        {
            List<SelectListItem> colors = new List<SelectListItem>();

            List<Color> _ListAllColors = new List<Color>();
            PropertyInfo[] _SystemColorProperties = typeof(SystemColors).GetProperties();
            foreach (PropertyInfo propertyInfo in _SystemColorProperties)
            {
                object colorObject = propertyInfo.GetValue(null, null);
                Color color = (Color)colorObject;
                if (!_ListAllColors.Contains(color))
                {
                    _ListAllColors.Add(color);
                }
            }

            foreach (KnownColor colorValue in Enum.GetValues(typeof(KnownColor)))
            {
                Color color = Color.FromKnownColor(colorValue);

                if (!_ListAllColors.Contains(color))
                {
                    colors.Add(new SelectListItem { Value = color.Name, Text = color.Name });
                }
            }

            return colors;
        }
        #endregion
    }
}