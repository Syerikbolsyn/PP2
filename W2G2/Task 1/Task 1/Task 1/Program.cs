using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_1
{
    class Program
    {
        static void t(string s)
        {
            int k = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != s[s.Length - 1 - i]) k++;

            }

            if (k != 0) Console.WriteLine("No");
            else Console.WriteLine("Yes");

        }

        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\Users\Серикболсын\Desktop\pp2\W2G2\Task 1\input.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string[] s = sr.ReadLine().Split();
            t(s[0]);


        }
    }
}
