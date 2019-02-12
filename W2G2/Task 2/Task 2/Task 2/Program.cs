using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_2
{
    class Program
    {
        static bool p (int a)
        {
            
            int k=0;
            for(int i = 1; i <= Math.Sqrt(a); i++)
            {  
                if (a % i == 0) k++;
            }
            if (k == 1) { return true; }
            else return false;
        }
        static void Main(string[] args)
        {string aq="";
            FileStream fs = new FileStream(@"C:\Users\Серикболсын\Desktop\pp2\W2G2\Task 2\input.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string sa = sr.ReadToEnd();
            string[] s = sa.Split();
            int[] ar= new int[s.Length];
            for (int i = 0; i < s.Length; i++) {
                
                    ar[i]= int.Parse(s[i]);
                    
            }
            for (int i = 0; i < s.Length; i++)
            {

                if (p(ar[i])) { aq += (ar[i] + " "); }

            }
            FileStream fs1 = new FileStream (@"C:\Users\Серикболсын\Desktop\pp2\W2G2\Task 2\output.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs1);
                  sw.Write(aq);

            Console.Write(aq);


            sw.Close();
            fs.Close();
            sr.Close();
            fs1.Close();
        }
    }
}
