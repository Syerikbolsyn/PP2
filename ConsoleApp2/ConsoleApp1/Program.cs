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
            int num;
            ;
            int num_1;
            
         const   float f=2.23f;
            bool s;
            s = true;
            string name = "Serikbolsyn";
            char r = 'D';

           
            num= Convert.ToInt32(      Console.ReadLine());

            
            
            num_1 = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("num= "+num);
            Console.WriteLine("\n num-1=" +num_1);
            Console.WriteLine("hosyndy:=" + (num + num_1));
        }


    }
}
