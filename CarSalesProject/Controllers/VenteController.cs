using CarSalesData;
using CarSalesData.Helpers;
using CarSalesProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarSalesProject.Controllers
{
    public class VenteController : Controller
    {
        // GET: Vente
        public ActionResult Index()
        {

            VenteViewModel vvm = new VenteViewModel()
            {
                Vehicule = VehiculeHelper.Current.GetList(),
                Commercial = PersonneHelper.Current.GetPersonByType(4),
                Client = PersonneHelper.Current.GetPersonByType(0),
                ContratAchat = new ContratAchat()

            };
            return View("Index", vvm);
        }

        [HttpPost]
        public ActionResult AjouterNouveauContratAchat(ContratAchat contratAchat)
        {
            Vehicule vehiculeVendu = VehiculeHelper.Current.GetItem(contratAchat.IdVehicule);
            vehiculeVendu.PrixAchat = contratAchat.Vehicule.PrixAchat;
            contratAchat.Vehicule = vehiculeVendu;


            ContratAchatHelper.Current.Insert(contratAchat);

            return RedirectToAction("Index", "Account");
        }
    }
}