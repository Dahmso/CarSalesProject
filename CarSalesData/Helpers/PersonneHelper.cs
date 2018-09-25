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
    }
}