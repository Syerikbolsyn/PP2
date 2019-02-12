using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Task_3
{
    class Program
    {
        static void o(int a)
        {
            for(int i=0;i<a;i++)
            Console.Write("     ");
        }
        static void Fshygaru(DirectoryInfo d,int k)
        {
            o(k);
            Console.WriteLine(d.Name);
            k++;
            FileInfo[] f = d.GetFiles();
            
            foreach (FileInfo file in f)
            {
               o(k);
                Console.WriteLine(file.Name);
            }
            DirectoryInfo[] dr = d.GetDirectories();
            foreach(DirectoryInfo directory in dr )
            {int r = k;


                Fshygaru(directory, r);

            }
           
        }
       
        static void Main(string[] args)
        {
            DirectoryInfo dy = new DirectoryInfo("C:/Users/Серикболсын/Desktop/pp2/W2G2");
            int k = 0;
            Fshygaru(dy,k);
        }
    }
}
