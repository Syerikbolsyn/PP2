using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Mark
{ [Serializable]
   public class Marks
    {
        int a;
        string c;
        public Marks(int a)
        {
           
         string c;

            if (a >= 95)
            {
                c = "A";
                this.c = c;
            }

            else if (a >= 90)
            {
                c = "A-";
                this.c = c;
            }
            else if (a >= 85)
            {
                c = "B+";
                this.c = c;
            }
            else if (a >= 80)
            {
                c = "B";
                this.c = c;
            }
            else if (a >= 75)
            {
                c = "B-";
                this.c = c;
            }

            this.a = a;
        }
        


        

        public void ToString()
        {
            Console.WriteLine(this.c);
        }
    

    }
}
