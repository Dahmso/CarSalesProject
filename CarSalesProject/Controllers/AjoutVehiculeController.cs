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
    public class AjoutVehiculeController : Controller
    {
        // GET: Inscription
        public ActionResult Index()
        {
            List<ConstructeursVoiture> marques = ConstructeursVoitureHelper.Current.GetList();
            
            VehiculeViewModel vvm = new VehiculeViewModel()
            {
                Vehicule = new Vehicule(),
                VehiculeOccasion = new VehiculeOccasion(),
                StatutsVehicule = new List<SelectListItem>
                {
                    new SelectListItem { Value = "0", Text = "Occasion"},
                    new SelectListItem { Value = "1", Text = "Neuf"}
                },
                CouleursVehicule = GetAllColors(),
                Marques = marques
            };

            return View("Index", vvm);
        }

        [HttpPost]
        public ActionResult Valider(Vehicule vehicule)
        {
            if (!ModelState.IsValid)
            {
                return Index();
            }
            
            VehiculeHelper.Current.Insert(vehicule);

            //

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public ActionResult Retour(Vehicule vehicule)
        {
            return RedirectToAction("Index", "GestionVehicule");
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
    }
}