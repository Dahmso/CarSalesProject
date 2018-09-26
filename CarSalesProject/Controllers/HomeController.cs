using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarSalesData;
using CarSalesData.Helpers;

namespace CarSalesProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Personne personne = new Personne();
            return View("Index", personne);
        }

        public ActionResult ValidationConnexion(Personne personne)
        {
            Personne p = PersonneHelper.Current.GetItem(personne.Email, personne.MotDePasse);
            if (p != null)
            {
                Session["Personne"] = p;
                return RedirectToAction("Index", "Account");
            }

            return Index();
        }

    }
}