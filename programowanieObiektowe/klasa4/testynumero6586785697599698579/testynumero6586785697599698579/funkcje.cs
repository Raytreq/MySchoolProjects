using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

// Simple program showcasing basic use of xunit with different arythmetic functions

namespace testynumero6586785697599698579
{
    public class funkcje
    {
        public double a;
        public double b;
        public double c;

        public double pole() {
            return (a + b + c )/ 2;
        }

        public double obwod()
        {
            return a + b + c;
        }

        public bool czyMozna()
        {
            if( a < b+c ||  b +a > c || b < c+a)
            {
                return true;
            }
            else
            {
                return false;
            }
        } 

        public bool czyRownoboczny()
        {
            if( a==b && b==c )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool czyRownoramienny()
        {
            if ( a==b || b==c  || a==c)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool czyProstokatny()
        {
            double a2 = c * c + b * b;
            double b2 = a * a + c * c;
            double c2 = a * a + b * b;

            if ( a2 ==  a*a || b2 == b*b || c2 == c*c)
            {
                return true;
            }
            else { return false;}
        }
    }
}
