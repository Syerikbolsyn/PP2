using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;

namespace Snake
{
    public class Kedergi:GameObj
    {
        enum Dengei
        {
            FIRST,
            SECOND,
            THIRD
        }

        Dengei dengei = Dengei.FIRST;
        public Kedergi(ConsoleColor color, char c ):base(0,0,color, c)
        {
            body = new List<Point>();
        }
        public void Kedergiohu()
        {
            body = new List<Point>();
            string fileName = @"C:\Users\Серикболсын\source\repos\Snake\Snake\TextFile1.txt";
            if(dengei==Dengei.SECOND) fileName = @"C:\Users\Серикболсын\Desktop\pp2\W6G2\Snake\Snake\TextFile2.txt";
            if (dengei == Dengei.THIRD) fileName = "3-dengei";


            StreamReader sr = new StreamReader(fileName);
            string[] oh = sr.ReadToEnd().Split('\n');
            for(int i=0;i<oh.Length;i++)
            {
                for (int j = 0; j < oh[i].Length; j++)
                {
                    if (oh[i][j] != '.')
                        body.Add(new Point(j, i));
                }
            }


        }
        public void NextLevel()
        {
            if (dengei == Dengei.FIRST)
                dengei = Dengei.SECOND;
            Kedergiohu();

        }

    }
}
