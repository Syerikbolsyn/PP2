using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Mark
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int a;
            a = int.Parse(Console.ReadLine());
            Marks m = new Marks(a);
           List<Marks> list = new List<Marks>();
            List<Marks> list2 = new List<Marks>();
            list.Add(m);
            int e = int.Parse(Console.ReadLine());
            Marks me = new Marks(e);
            list.Add(me);
            me.ToString();

            int ee = int.Parse(Console.ReadLine());
            Marks mee = new Marks(ee);
            list.Add(mee);
            FileStream fss = new FileStream("Ss1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fss, list);
            fss.Close();
            FileStream fs = new FileStream("Ss1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf2 = new BinaryFormatter();
         
            List<Marks> list1 = bf2.Deserialize(fs) as List<Marks>;
            fss.Close();
            foreach (Marks mr in list1)
            {
                mr.ToString();
            }
        
       
            
        }
        
    }
}
