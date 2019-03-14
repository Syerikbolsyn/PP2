using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Complex
{  [Serializable]
    public class Complex
      
    {
        
        public  double a;
        public double b;

        public double A { get => a; set => a = value; }

        public Complex(double a, double b)
        {
            this.A = a;
            this.b = b;
        }
        public Complex()
        {
           
        }

        public Complex Add (Complex c1, Complex c2)
        {
           
            double a3 = c1.A + c2.A;
            double b3 = c1.b + c2.b;
            Complex c3 = new Complex();
            c3.A = a3;
            c3.b = b3;
            return c3;

        }
        public Complex Mult(Complex c1, Complex c2)
        {

            double a3 = c1.A * c2.A-c1.b * c2.b;
            double b3 = c1.b*c2.A + c2.b*c1.A;
            Complex c3 = new Complex();
            c3.A = a3;
            c3.b = b3;
            return c3;

        }
        public Complex Over(Complex c1, Complex c2)
        {

            double a3 = (c1.A /c2.b+ c1.b/c2.A)*(c2.A*c2.b)/(c2.A*c2.A+c2.b*c2.b);
            double b3 = (a3-c1.A)/ c2.b;
            Complex c3 = new Complex();
            c3.A = a3;
            c3.b = b3;
            return c3;

        }
        public Complex Minusadd(Complex c1, Complex c2)
        {

            double a3 = c1.A -c2.A;
            double b3 = c1.b - c2.b;
            Complex c3 = new Complex();
            c3.A = a3;
            c3.b = b3;
            return c3;

        }

    }
}
