using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esep1
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0,r=0;                      //jai sandy tekserushi, sany
            int n=int.Parse(Console.ReadLine());        //kansha san ekenin engizemiz
            string s = Console.ReadLine();        // sandardy engizemiz string arkyly
            string[] sr = s.Split();         // stringtin ar elementin sr -ge salayk
            int[] prime = new int[n];                               // jai sandardyn array-i
            int[] ar = new int[n] ;              //"ar"-degen array kuraiyk; berilgen sandardy sogan salamyz
            for (int i = 0; i < n; i++)
            {
                prime[i] = 0;                   //aldymen bul array-di 0-darmen toltyryp alaiyk
            }
            for (int i = 0; i < n; i++)
            {
                ar[i] = int.Parse(sr[i]);                  // ar-da berilgen sandar
                for(int j=1;j<=Math.Sqrt(ar[i]); j++)
                {
                    if (ar[i] % j == 0) k++;                     // jai san b a jok pa tekserip jatyrmyz
                    

                }
                if (k == 1 && ar[i]!=1) { prime[i] = ar[i]; r++; } // jai sandardy engizip jatyrmyz
                k = 0;
            }
            Console.WriteLine(r); // kansha jai san bar ekenin shygaramyz
            
            for (int i=0;i<n;i++)
            {
               if(prime[i]!=0) Console.Write(prime[i]+" "); // jai sandardy shygaramyz
            }
        }
    }
}
