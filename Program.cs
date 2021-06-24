using System;

namespace numeric_func_w_bitwise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(abs(-5));
            //Console.WriteLine(isPositive(-20));
            //Console.WriteLine(isPositive(20));
            //Console.WriteLine(isNegative(5));
            //Console.WriteLine(isNegative(-5));
            //Console.WriteLine(isOdd(14));
            //Console.WriteLine(isOdd(11));
            Console.WriteLine(isEven(7));
            Console.WriteLine(isEven(8));
        }

        static int abs(int x)
        {
            //Este la hice de manera correcta desde el principio porque vi un referencia en stack overflow https://stackoverflow.com/questions/60601908/absolute-value-absx-using-bitwise-operators-and-boolean-logic
            ushort z = 5;
            var test = x | z;
            if (test <= 0)
            {
                var mask = x >> (31);
                return ((x + mask) ^ mask);
                //return -x;
            }
            else
            {
                return x;
            }
        }

        static bool isPositive(int x)
        {
            var mask = x >> 31;
            bool result;
            if ((mask | 0) == 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }

        static bool isNegative(int x)
        {
            var mask = x>>31;
            bool result;
            if ((mask & 1) == 1)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }

        static bool isOdd(int x)
        {
            bool result;
            if ((x ^ 1) == x + 1)
            {
                result = false;
            }
            else
            {
                result = true;
            }

            return result;
        }

        static bool isEven(int x)
        {
            bool result;
            if ((x ^ 1) == x + 1)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }
    }
}
