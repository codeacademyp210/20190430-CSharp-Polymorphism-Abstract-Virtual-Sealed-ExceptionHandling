using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling.Exceptions
{
    class TempLowerThanTen : Exception
    {
        public TempLowerThanTen(string message) : base(message)
        {

        }
    }
}
