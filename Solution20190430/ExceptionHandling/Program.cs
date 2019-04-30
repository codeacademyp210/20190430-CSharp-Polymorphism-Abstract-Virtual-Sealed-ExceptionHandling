using ExceptionHandling.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //int result = Divide(20, 5);

            //Console.WriteLine(result);


            Temperature t = new Temperature();
            try
            {
                t.Temp = 15;
                t.Divide(10, 0);
            }
            catch (TempLowerThanTen e)
            {
                Console.WriteLine($"Temperature exception: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception occured: {e.Message}");
            }

            Console.WriteLine(t.Temp);
            Console.ReadLine();
        }

        public static int Divide(int a, int b)
        {
            int res = 0;
            try
            {
                res = a / b;
            }
            catch (Exception)
            {
                Console.WriteLine($"Exception handled:");
            } finally
            {
                Console.WriteLine("finally");
            }


            return res;
        }
             
    }
}
