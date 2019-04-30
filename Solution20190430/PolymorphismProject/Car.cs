using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismProject
{
    abstract class Car
    {
        public int Doors()
        {
            return 4;
        }

        public abstract string GetName();
    }
}
