using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarSalesData.Helpers
{
    public class VehiculeHelper
    {
        #region Thread-safe, lazy Singleton
        /// <summary>
        /// This is a thread-safe, lazy singleton. See
        /// http://www.yoda.arachsys.com/csharp/singleton.html
        /// for more details about its implementation.
        /// </summary>
        public static VehiculeHelper Current
        {
            get
            {
                return Nested.VehiculeHelper;
            }
        }
        class Nested
        {
            // Explicit static constructor to tell C# compiler
            // not to mark type as beforefieldinit
            static Nested()
            {
            }
            internal static readonly VehiculeHelper VehiculeHelper = new VehiculeHelper();
        }
        #endregion
        #region Fields
        private CarSalesEntities _db;
        #endregion

        #region Methods
        /// <summary>
        /// Retourne un objet métier
        /// </summary>
        /// <param id="id">id</param>
        /// <returns>objet métier</returns>
        public Vehicule GetItem(int id)
        {
            using (_db = new CarSalesEntities())
            {
                return _db.Vehicule.Find(id);
            }
        }

        /// <summary>
        /// Retourne une liste d'objet
        /// </summary>
        /// <returns>Liste d'objet métier</returns>
        public List<Vehicule> GetList()
        {
            using (_db = new CarSalesEntities())
            {
                return _db.Vehicule.ToList();
            }
        }

        public void Insert(Vehicule Vehicule)
        {
            using (_db = new CarSalesEntities())
            {
                _db.Vehicule.Add(Vehicule);
                _db.SaveChanges();
            }
        }

        public void Update(Vehicule Vehicule)
        {
            using (_db = new CarSalesEntities())
            {
                _db.Entry(Vehicule).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();
            }
        }

        public void Delete(Vehicule Vehicule)
        {
            using (_db = new CarSalesEntities())
            {
                _db.Entry(Vehicule).State = System.Data.Entity.EntityState.Deleted;
                _db.SaveChanges();
            }
        }
        #endregion
    }
}