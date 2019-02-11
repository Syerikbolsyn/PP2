using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;   // arraydin kolemi
            n = int.Parse(Console.ReadLine()); // ony engizgende butin man kylyp kabyldaidy
            string s = Console.ReadLine();  // berilgen sandardy aldymen string-de kylyp kabyldatamyz
            string[ ] ar = s.Split() ;      // sosyn onyn ar elemetin ar -degen arrayga salamyz
            string[] a = new string[2 * n]; // shygaruga tiisti narsemizdi sahtaityn "a"-dehen array kuramyz a ol ar-dan 2 ese ulken boluy kerek sondyktan 2*n bolu kerek
            for (int i = 0; i < n; i++)
            {
                a[2 * i] = ar[i];           // a-ny ar- arkyly toltyramyz
                a[2 * i + 1] = ar[i];

            }
            for (int i = 0; i < 2 * n; i++)
            {
                Console.Write(a[i] + " "); // a -dagy bar elementti shygaramyz

            }

        }


    }
}
