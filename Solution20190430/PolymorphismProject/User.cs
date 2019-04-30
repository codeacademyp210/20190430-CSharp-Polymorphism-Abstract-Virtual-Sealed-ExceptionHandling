using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismProject
{
    class User
    {
        public virtual void GetInfo()
        {
            Console.WriteLine("User class");
        }
    }
}
