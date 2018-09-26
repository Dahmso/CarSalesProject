using CarSalesData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarSalesProject.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            Personne personne = (Personne)Session["Personne"];
            
            return View(personne);
        }
    }
}