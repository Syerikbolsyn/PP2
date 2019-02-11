using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esep4

{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());   // arraydin uzindygy bolatyn sandy engizemiz
            string[ , ] s = new string[n, n];   // 2D array kuramyz
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (i >= j) s[i, j] = "[*]";  Console.Write(s[i,j]);    // s - arrayinen kerekti oryndy(i>=j boluy kerek) [*]-men toltyramyz da sosyn sony shygaramyz
      
                    
                }
                Console.WriteLine();  //array din joldary Jeke-jeke korinui ushin Write"Line"- deimiz
            }



        }
    }
}
