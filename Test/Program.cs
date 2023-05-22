using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            public void Main()
            {
                Console.WriteLine(GetMinX(2, 5, 3));
                Console.WriteLine(GetMinX(0, 3, 2));
                Console.WriteLine(GetMinX(1, -2, -3));
                Console.WriteLine(GetMinX(5, 2, 1));
                Console.WriteLine(GetMinX(4, 3, 2));
                Console.WriteLine(GetMinX(0, 4, 5));

                // А в этих случаях решение существует:
                Console.WriteLine(GetMinX(0, 0, 2) != "Impossible");
                Console.WriteLine(GetMinX(0, 0, 0) != "Impossible");
            }

            private string GetMinX(int a, int b, int c)
            {
                if (a <= 0)
                {
                    return "Impossible";
                }

                double minX = -b / (2 * a);
                return minX.ToString();
            }
        }
    }
}
