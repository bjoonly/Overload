using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload
{
   

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Square s1 = new Square(5), s2 = new Square(10);
                int num;
                Rectangle r1 = new Rectangle(2, 5), r2 = new Rectangle(5, 7), r3;
                Console.WriteLine($"Square 1:\n{s1}\nSquare 2:\n{s2}\nRectangle 1:\n{r1}\nRectangle 2:\n{r2}\n");

                Console.WriteLine("\n" + new string('-', 25) + "\n");

                Console.WriteLine($"++S1:\n{ ++s1}\n++R1:\n{++r1}\n--S2:\n{--s2}\n--R2:\n{--r2}\n");

                Console.WriteLine(new string('-', 25));

                Console.WriteLine($"S1+3:\n{s1 + 3}\n");
                Console.WriteLine($"S1-2:\n{s1 - 2}\n");
                Console.WriteLine($"S1*7:\n{s1 * 7}\n");
                Console.WriteLine($"S1/3:\n{s1 / 3}\n");

                Console.WriteLine("\n" + new string('-', 25) + "\n");

                Console.WriteLine($"R1+5:\n{r1 + 5}\n");
                Console.WriteLine($"R1-1:\n{r1 - 1}\n");
                Console.WriteLine($"R1*3:\n{r1 * 3}\n");
                Console.WriteLine($"R1/2:\n{r1 / 2}\n");

                Console.WriteLine("\n" + new string('-', 25) + "\n");

                Console.WriteLine("S1<S2? " + (s1 < s2) + "\n");
                Console.WriteLine("S2>S1? " + (s2 > s1) + "\n");
                Console.WriteLine("S2<=S1? " + (s2 <= s1) + "\n");
                Console.WriteLine("S2>=S1? " + (s2 >= s1) + "\n");
                Console.WriteLine("S1==S2? " + (s1 == s2) + "\n");
                Console.WriteLine("S1!=S2? " + (s1 != s2) + "\n");

                Console.WriteLine("\n" + new string('-', 25) + "\n");

                Console.WriteLine("R1<R2? " + (r1 < r2) + "\n");
                Console.WriteLine("R2>R1? " + (r2 > r1) + "\n");
                Console.WriteLine("R2<=R1? " + (r2 <= r1) + "\n");
                Console.WriteLine("R2>=R1? " + (r2 >= r1) + "\n");
                Console.WriteLine("R1==R2? " + (r1 == r2) + "\n");
                Console.WriteLine("R1!=R2? " + (r1 != r2) + "\n");

                Console.WriteLine("\n" + new string('-', 25) + "\n");

                num = s1;
                Console.WriteLine("S1 to int: " + num + "\n");
                Console.WriteLine("R1 to int: " + (int)r1 + "\n");

                Console.WriteLine("\n" + new string('-', 25) + "\n");

                r3 = s2;
                Console.WriteLine("S2 to Rectangle:\n" + r3 + "\n");
                Console.WriteLine("R2 to Square:\n" + (Square)r2 + "\n");

                Console.WriteLine("\n" + new string('-', 25) + "\n");

                Console.WriteLine("\nif(s1):\n");
                if (s1)
                    Console.WriteLine("True\n");
                else
                    Console.WriteLine("False\n");

                Console.WriteLine("\n" + new string('-', 25) + "\n");
                Console.WriteLine("\nif(r1):\n");
                if (r1)
                    Console.WriteLine("True\n");
                else
                    Console.WriteLine("False\n");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
