using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismProject
{
    class Program
    {
        static void Main(string[] args)
        {

            //Print p = new Print();

            //Console.WriteLine(p.Display("Parvin", "Pashazade", "Test"));

            //Console.WriteLine(p.Card());

            //string[,] names = new string[,] {
            //    { "Rauf", "Togrul", "Rustem" },
            //    {"Heyder", "Parvin", "Tamerlan" },
            //    {"Heyder", "Parvin", "Tamerlan" },
            //    {"Heyder", "Parvin", "Tamerlan" },
            //    {"Heyder", "Parvin", "Tamerlan" },
            //    {"Heyder", "Parvin", "Tamerlan" },
            //    {"Heyder", "Parvin", "Tamerlan" },
            //    {"Heyder", "Parvin", "Tamerlan" },
            //    {"Heyder", "Parvin", "Tamerlan" },
            //    {"Heyder", "Parvin", "Tamerlan" },
            //    {"Heyder", "Parvin", "Tamerlan" },
            //    {"Heyder", "Parvin", "Tamerlan" },
            //    {"Heyder", "Parvin", "Tamerlan" },
            //    {"Heyder", "Parvin", "Tamerlan" }
            //};
            //Console.WriteLine( names[0, 0] );

            //Console.WriteLine(names.GetUpperBound(1));


            //Car myCar = new Car();
            //Console.WriteLine(myCar.Doors());

            //Kia kia = new Kia();
            //Console.WriteLine(kia.Doors());
            //Console.WriteLine(kia.GetName());

            Details details = new Details();
            details.GetInfo();


            Console.ReadLine();
        }
    }
}
