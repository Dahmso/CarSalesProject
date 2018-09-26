using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarSalesData.Helpers
{
    public class PersonneHelper
    {
        #region  Thread-safe,  lazy  Singleton

        ///  <summary>
        ///  This  is  a  thread-safe,  lazy  singleton.  See  http://www.yoda.arachsys.com/csharp/singleton.html    
        ///  for  more  details  about  its  implementation.
        ///  </summary>

        public static PersonneHelper Current

        {
            get
            {
                return Nested.PersonneHelper;
            }

        }

        class Nested

        {
            //  Explicit  static  constructor  to  tell  C#  compiler
            //  not  to  mark  type  as  beforefieldinit

            static Nested()
            {

            }

            internal static readonly PersonneHelper PersonneHelper = new PersonneHelper();
        }
        #endregion

        #region  Fields
        private CarSalesEntities _db;
        #endregion

        #region Methods
        public List<Personne> GetList()
        {
            using (_db = new CarSalesEntities())
            {
                return _db.Personne.ToList();
            }
        }
        public Personne GetItem(string email, string mdp)
        {
            using (_db = new CarSalesEntities())
            {
                Personne p = null;

                var query = from personne in _db.Personne
                            where personne.Email == email && personne.MotDePasse == mdp
                            select personne;

                if (query.Count() > 0)
                {
                    p = query.First();
                }

                return p;
            }
        }

        public List<Personne> GetPersonByType(int typePerson)
        {
            using (_db = new CarSalesEntities())
            {
                var query = from personne in _db.Personne
                            where personne.TypePersonne == typePerson
                            select personne;
                List<Personne> personnes = query.ToList<Personne>();

                return personnes;
            }
        }
        #endregion
    }
}