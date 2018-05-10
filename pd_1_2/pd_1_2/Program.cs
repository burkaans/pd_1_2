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
        }
        static string Funkcija(string vards1, string vards2)
        {
            string result ="jus ievadijat vardu " + vards1 +" un vardu " + vards2;
            return result;

        }
    }
}
