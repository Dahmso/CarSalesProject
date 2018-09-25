using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarSalesData.Helpers
{
    public class EmployeHelper
    {
        #region  Thread-safe,  lazy  Singleton

        ///  <summary>
        ///  This  is  a  thread-safe,  lazy  singleton.  See  http://www.yoda.arachsys.com/csharp/singleton.html    
        ///  for  more  details  about  its  implementation.
        ///  </summary>

        public static EmployeHelper Current

        {
            get
            {
                return Nested.EmployeHelper;
            }

        }

        class Nested

        {
            //  Explicit  static  constructor  to  tell  C#  compiler
            //  not  to  mark  type  as  beforefieldinit

            static Nested()
            {

            }

            internal static readonly EmployeHelper EmployeHelper = new EmployeHelper();
        }
        #endregion

        #region  Fields
        private CarSalesEntities _db;
        #endregion

        #region Methods
        /// <summary>
        /// Retourne un objet métier
        /// </summary>
        /// <param id="id">id</param>
        /// <returns>objet métier</returns>
        public Client GetItem(int id)
        {
            using (_db = new CarSalesEntities())
            {
                return _db.Client.Find(id);
            }
        }

        /// <summary>
        /// Retourne une liste d'objet
        /// </summary>
        /// <returns>Liste d'objet métier</returns>
        public List<Client> GetList()
        {
            using (_db = new CarSalesEntities())
            {
                return _db.Client.ToList();
            }
        }

        public void Insert(Client client)
        {
            using (_db = new CarSalesEntities())
            {
                _db.Client.Add(client);
                _db.SaveChanges();
            }
        }

        public void Update(Client client)
        {
            using (_db = new CarSalesEntities())
            {
                _db.Entry(client).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();
            }
        }
        #endregion
    }
}
