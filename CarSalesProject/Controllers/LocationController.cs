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
    public class LocationController : Controller
    {
        // GET: Location
        public ActionResult Index()
        {

            LocationViewModel lvm = new LocationViewModel() {
                Vehicule = VehiculeHelper.Current.GetList(),
                Commercial = PersonneHelper.Current.GetPersonByType(4),
                Client = PersonneHelper.Current.GetPersonByType(0)

        };
            return View("Index", lvm);
        }

        [HttpPost]
        public ActionResult AjouterNouvelleLocation(Location location)
        {  
            LocationHelper.Current.Insert(location);

            return RedirectToAction("Index", "Account");
        }
    }
}