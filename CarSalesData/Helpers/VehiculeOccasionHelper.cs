using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarSalesData.Helpers
{
    public class VehiculeOccasionHelper
    {
        #region Thread-safe, lazy Singleton
        /// <summary>
        /// This is a thread-safe, lazy singleton. See
        /// http://www.yoda.arachsys.com/csharp/singleton.html
        /// for more details about its implementation.
        /// </summary>
        public static VehiculeOccasionHelper Current
        {
            get
            {
                return Nested.VehiculeOccasionHelper;
            }
        }
        class Nested
        {
            // Explicit static constructor to tell C# compiler
            // not to mark type as beforefieldinit
            static Nested()
            {
            }
            internal static readonly VehiculeOccasionHelper VehiculeOccasionHelper = new VehiculeOccasionHelper();
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
        public VehiculeOccasion GetItem(int id)
        {
            using (_db = new CarSalesEntities())
            {
                return _db.VehiculeOccasion.Find(id);
            }
        }
        /*
        public VehiculeOccasion GetItem(string email, string mdp)
        {
            using (_db = new CarSalesEntities())
        {
                VehiculeOccasion j = null;

                var query = from VehiculeOccasion in _db.VehiculeOccasion
                            where VehiculeOccasion.Email == email && VehiculeOccasion.MotDePasse == mdp
                            select VehiculeOccasion;

                if (query.Count() > 0)
                {
                    j = query.First();
                }
                    
                return j;
            }
        }
        */
        /// <summary>
        /// Retourne une liste d'objet
        /// </summary>
        /// <returns>Liste d'objet métier</returns>
        public List<VehiculeOccasion> GetList()
        {
            using (_db = new CarSalesEntities())
            {
                return _db.VehiculeOccasion.ToList();
            }
        }

        public void Insert(VehiculeOccasion VehiculeOccasion)
        {
            using (_db = new CarSalesEntities())
            {
                _db.VehiculeOccasion.Add(VehiculeOccasion);
                _db.SaveChanges();
            }
        }

        public void Update(VehiculeOccasion VehiculeOccasion)
        {
            using (_db = new CarSalesEntities())
            {
                _db.Entry(VehiculeOccasion).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();
            }
        }

        public void Delete(VehiculeOccasion VehiculeOccasion)
        {
            using (_db = new CarSalesEntities())
            {
                _db.Entry(VehiculeOccasion).State = System.Data.Entity.EntityState.Deleted;
                _db.SaveChanges();
            }
        }
        #endregion
    }
}