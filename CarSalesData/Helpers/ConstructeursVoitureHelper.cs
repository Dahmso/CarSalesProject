using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarSalesData.Helpers
{
    public class ConstructeursVoitureHelper
    {
        #region Thread-safe, lazy Singleton
        /// <summary>
        /// This is a thread-safe, lazy singleton. See
        /// http://www.yoda.arachsys.com/csharp/singleton.html
        /// for more details about its implementation.
        /// </summary>
        public static ConstructeursVoitureHelper Current
        {
            get
            {
                return Nested.ConstructeursVoitureHelper;
            }
        }
        class Nested
        {
            // Explicit static constructor to tell C# compiler
            // not to mark type as beforefieldinit
            static Nested()
            {
            }
            internal static readonly ConstructeursVoitureHelper ConstructeursVoitureHelper = new ConstructeursVoitureHelper();
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
        public ConstructeursVoiture GetItem(int id)
        {
            using (_db = new CarSalesEntities())
            {
                return _db.ConstructeursVoiture.Find(id);
            }
        }

        /// <summary>
        /// Retourne une liste d'objet
        /// </summary>
        /// <returns>Liste d'objet métier</returns>
        public List<ConstructeursVoiture> GetList()
        {
            using (_db = new CarSalesEntities())
            {
                return _db.ConstructeursVoiture.ToList();
            }
        }

        public void Insert(ConstructeursVoiture ConstructeursVoiture)
        {
            using (_db = new CarSalesEntities())
            {
                _db.ConstructeursVoiture.Add(ConstructeursVoiture);
                _db.SaveChanges();
            }
        }

        public void Update(ConstructeursVoiture ConstructeursVoiture)
        {
            using (_db = new CarSalesEntities())
            {
                _db.Entry(ConstructeursVoiture).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();
            }
        }

        public void Delete(ConstructeursVoiture ConstructeursVoiture)
        {
            using (_db = new CarSalesEntities())
            {
                _db.Entry(ConstructeursVoiture).State = System.Data.Entity.EntityState.Deleted;
                _db.SaveChanges();
            }
        }
        #endregion
    }
}
