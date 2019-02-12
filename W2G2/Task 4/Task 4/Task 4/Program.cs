using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s= @"synauyk.txt";
     
            var v=File.Create(@"C:\Users\Серикболсын\Desktop\pp2\W2G2\Task 4\"+s);
            v.Close();
            File.Copy(@"C:\Users\Серикболсын\Desktop\pp2\W2G2\Task 4\" + s, @"C:\Users\Серикболсын\Desktop\pp2\W2G2\Task 4\Copy\" + s);

           FileInfo fi = new FileInfo(@"C:\Users\Серикболсын\Desktop\pp2\W2G2\Task 4\" + s);
            
            fi.Delete();
        }
    }
}
 