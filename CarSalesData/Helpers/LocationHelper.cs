using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarSalesData.Helpers
{
    public class LocationHelper
    {
        #region Thread-safe, lazy Singleton
        /// <summary>
        /// This is a thread-safe, lazy singleton. See
        /// http://www.yoda.arachsys.com/csharp/singleton.html
        /// for more details about its implementation.
        /// </summary>
        public static LocationHelper Current
        {
            get
            {
                return Nested.LocationHelper;
            }
        }
        class Nested
        {
            // Explicit static constructor to tell C# compiler
            // not to mark type as beforefieldinit
            static Nested()
            {
            }
            internal static readonly LocationHelper LocationHelper = new LocationHelper();
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
        public Location GetItem(int id)
        {
            using (_db = new CarSalesEntities())
            {
                return _db.Location.Find(id);
            }
        }

        /// <summary>
        /// Retourne une liste d'objet
        /// </summary>
        /// <returns>Liste d'objet métier</returns>
        public List<Location> GetList()
        {
            using (_db = new CarSalesEntities())
            {
                return _db.Location.ToList();
            }
        }

        public void Insert(Location Location)
        {
            using (_db = new CarSalesEntities())
            {
                _db.Location.Add(Location);
                _db.SaveChanges();
            }
        }

        public void Update(Location Location)
        {
            using (_db = new CarSalesEntities())
            {
                _db.Entry(Location).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();
            }
        }

        public void Delete(Location Location)
        {
            using (_db = new CarSalesEntities())
            {
                _db.Entry(Location).State = System.Data.Entity.EntityState.Deleted;
                _db.SaveChanges();
            }
        }
        #endregion
    }
}