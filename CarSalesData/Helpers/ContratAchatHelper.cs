using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarSalesData.Helpers
{
    public class ContratAchatHelper
    {
        #region  Thread-safe,  lazy  Singleton

        ///  <summary>
        ///  This  is  a  thread-safe,  lazy  singleton.  See  http://www.yoda.arachsys.com/csharp/singleton.html    
        ///  for  more  details  about  its  implementation.
        ///  </summary>

        public static ContratAchatHelper Current

        {
            get
            {
                return Nested.ContratAchatHelper;
            }

        }

        class Nested

        {
            //  Explicit  static  constructor  to  tell  C#  compiler
            //  not  to  mark  type  as  beforefieldinit

            static Nested()
            {

            }

            internal static readonly ContratAchatHelper ContratAchatHelper = new ContratAchatHelper();
        }
        #endregion

        #region  Fields
        private CarSalesEntities _db;
        #endregion

        #region Methods
        public void Insert(ContratAchat contratAchat)
        {
            using (_db = new CarSalesEntities())
            {
                _db.ContratAchat.Add(contratAchat);
                _db.SaveChanges();
            }
        }
        #endregion
    }
}
