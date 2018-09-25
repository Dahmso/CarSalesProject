using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarSalesData;
using CarSalesData.Helpers;
using CarSalesProject.ViewModels;

namespace CarSalesProject.Controllers
{
    public class GestionVehiculesController : Controller
    {
        // GET: Inscription
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

            return RedirectToAction("Index", "AjoutVehicule");
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
    }
}