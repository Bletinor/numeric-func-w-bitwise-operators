using System;

namespace numeric_func_w_bitwise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(abs(-5));
            Console.WriteLine(isPositive(20));
            Console.WriteLine(isNegative(-5));
            Console.WriteLine(isOdd(9));
            Console.WriteLine(isEven(8));
        }

        static int abs(int x)
        {
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
            ushort z = 10;
            var test = x | z;
            bool result; 
            if (test > 0)
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
            ushort z = 10;
            var test = x | z;
            bool result;
            if (test > 0)
            {
                result = false;
            }
            else
            {
                result = true;
            }

            return result;
        }

        static bool isOdd(int x)
        {
            var test = x%2 | 0;
            bool result;
            if (test == 0)
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
            var test = x % 2 | 0;
            bool result;
            if (test == 0)
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
