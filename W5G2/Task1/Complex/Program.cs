using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Complex
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex complex = new Complex(21, 42);
            Complex c = new Complex(111, 412);
            Complex t = new Complex();
            t=t.Add(complex, c);
          



            FileStream fs = new FileStream("data.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, t);
            fs.Close();

            bf = new BinaryFormatter();
            FileStream fss = new FileStream("data.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            Complex t1 = bf.Deserialize(fss) as Complex;
            Console.WriteLine("Deserialization" + t1.a +" "+ t1.b);
            Console.ReadKey();


        }
    }
}
