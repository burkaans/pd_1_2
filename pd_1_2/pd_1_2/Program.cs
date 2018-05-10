using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pd_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ludzu ievadiet divas simbolu virknes, lai varu tas apvienot!");
            string var1, var2;
            var1 = Console.ReadLine();
            var2 = Console.ReadLine();
            string rezultats = Funkcija(var1, var2);
            Console.WriteLine(rezultats);
            Console.ReadLine();

            Console.WriteLine("Ievadi pirmo skaitli");
            double skaitlis1, skaitlis2;
            double rezultats1, rezultats2, rezultats3, rezultats4;
            string ievade1 = Console.ReadLine();
            skaitlis1 = Convert.ToInt16(ievade1);
            Console.WriteLine("Ievadi otro skaitli");
            string ievade2 = Console.ReadLine();
            skaitlis2 = Convert.ToInt16(ievade2);
            rezultats1 = skaitlis1 + skaitlis2;
            rezultats2 = skaitlis1 - skaitlis2;
            rezultats3 = skaitlis1 * skaitlis2;
            rezultats4 = skaitlis1 / skaitlis2;
            Console.WriteLine("Rakstiet - summa, ja gribiet saskaitit, rakstiet - starpiba, ja velaties atnemt, rakstiet - reizinajums, ja velaties reizinat, rakstiet - dalijums, ja velaties dalit!");
            string ievade3 = Console.ReadLine();
            if (ievade3 == "summa")
            {
                Console.WriteLine(rezultats1);
            }
            else if (ievade3 == "starpiba")
            {
                Console.WriteLine(rezultats2);
            }
            else if (ievade3 == "reizinajums")
            {
                Console.WriteLine(rezultats3);
            }
            else if (ievade3 == "dalijums")
            {
                Console.WriteLine(rezultats4);
            }
            else
            {
                Console.WriteLine("Error!");
            }
            Console.ReadLine();

            Console.WriteLine("Ievadiet GPA skaitli un uzziniet savu vertejumu");
            string ievads = Console.ReadLine();
            switch (ievads)
            {

                case "4.5":
                    Console.WriteLine("A+ - Exceptional");
                    break;
                case "4":
                    Console.WriteLine("A - Excellent");
                    break;
                case "3.5":
                    Console.WriteLine("B+ - Very good");
                    break;
                case "3":
                    Console.WriteLine("B - Good");
                    break;
                case "2.5":
                    Console.WriteLine("C+ - Satisfactory");
                    break;
                case "2":
                    Console.WriteLine("C - Adequate");
                    break;
                case "1":
                    Console.WriteLine("D - Marginal");
                    break;
                case "0":
                    Console.WriteLine("F - Failure");
                    break;
                default:
                    Console.WriteLine("Error! ievadiet pareizu GPA skaitli ar cipariem!");
                    break;
            }
            Console.ReadLine();

            Console.WriteLine("Ievadiet skaitli, ko velaties kapinat!");
            double b = Aprekins();
            Console.WriteLine(b);
            Console.ReadLine();
        }
        static double Aprekins()
        {
            double sk;
            string input = Console.ReadLine();
            sk = Convert.ToDouble(input);
            double a = sk * sk;
            return a;
        }
        static string Funkcija(string vards1, string vards2)
        {
            string result ="jus ievadijat vardu " + vards1 +" un vardu " + vards2;
            return result;

        }
    }
}
