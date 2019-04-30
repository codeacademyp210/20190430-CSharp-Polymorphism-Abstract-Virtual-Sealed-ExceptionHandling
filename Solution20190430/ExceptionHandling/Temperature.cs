using ExceptionHandling.Exceptions;
using System;

namespace ExceptionHandling
{
    class Temperature
    {
        private int _Temp;

        public int Temp
        {
            get
            {
                return _Temp;
            }

            set
            {
                if (value <= 10)
                {
                    throw new TempLowerThanTen("Temperature must be greater than 10");
                }
                _Temp = value;
            }
        }

        public int Divide(int a, int b)
        {
            int res = 0;
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            return res;
        }
    }
}
