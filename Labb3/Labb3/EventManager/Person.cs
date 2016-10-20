using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3
{
    class Person
    {
        #region Properties

        private string FullName { get; set; }

        #endregion

        #region Constructor

        public Person(string inputFullName)
        {
            FullName = inputFullName;
        }

        #endregion

        #region GetFullNameMethod

        public string GetFullName()
        {
            return FullName;
        }

        #endregion
    }
}
