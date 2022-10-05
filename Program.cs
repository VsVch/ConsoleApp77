using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {

            string town = Console.ReadLine();
            double prodajbi = double.Parse(Console.ReadLine());

            if (town=="Sofia")
            {
                if (0<=prodajbi && prodajbi<=500)
                {
                    double com = prodajbi * 5 / 100;
                    Console.WriteLine("{0:f2}",com);
                }
                else if (500<prodajbi&&prodajbi<=1000)
                {
                    double com = prodajbi * 7 / 100;
                    Console.WriteLine("{0:f2}",com);
                }
                else if (1000<prodajbi&&prodajbi<=10000)
                {
                    double com = prodajbi * 8 / 100;
                    Console.WriteLine("{0:f2}", com);
                }
                else if (prodajbi>10000)
                {
                    double com = prodajbi * 12 / 100;
                    Console.WriteLine("{0:f2}", com);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (town == "Varna")
            {
                if (0 <= prodajbi && prodajbi <= 500)
                {
                    double com = prodajbi * 4.5 / 100;
                    Console.WriteLine("{0:f2}", com);
                }
                else if (500 < prodajbi && prodajbi <= 1000)
                {
                    double com = prodajbi * 7.5 / 100;
                    Console.WriteLine("{0:f2}", com);
                }
                else if (1000 < prodajbi && prodajbi <= 10000)
                {
                    double com = prodajbi * 10 / 100;
                    Console.WriteLine("{0:f2}", com);
                }
                else if (prodajbi > 10000)
                {
                    double com = prodajbi * 13 / 100;
                    Console.WriteLine("{0:f2}", com);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (town == "Plovdiv")
            {
                if (0 <= prodajbi && prodajbi <= 500)
                {
                    double com = prodajbi * 5.5 / 100;
                    Console.WriteLine("{0:f2}", com);
                }
                else if (500 < prodajbi && prodajbi <= 1000)
                {
                    double com = prodajbi * 8 / 100;
                    Console.WriteLine("{0:f2}", com);
                }
                else if (1000 < prodajbi && prodajbi <= 10000)
                {
                    double com = prodajbi * 12 / 100;
                    Console.WriteLine("{0:f2}", com);
                }
                else if (prodajbi > 10000)
                {
                    double com = prodajbi * 14.5 / 100;
                    Console.WriteLine("{0:f2}", com);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }

        }
    }
}
