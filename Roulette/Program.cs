using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            string b;
            do
            {
                Console.Clear();
                List<string> results = new List<string>();
                Bets gambeling = new Bets();
                results = gambeling.Gambeling();
                foreach (string a in results)
                {
                    Console.WriteLine(a);
                    Console.WriteLine("____________________________________________________________________|");
                }
                Console.WriteLine("\n\nDo you want to gamble again? Y/N");
                b = Console.ReadLine().ToLower();
            }
            while (b == "y");
            Console.ReadKey();
        }
    }
}
    

