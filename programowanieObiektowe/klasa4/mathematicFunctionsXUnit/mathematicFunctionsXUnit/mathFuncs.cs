using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathematicFunctionsXUnit
{
    public class mathFuncs
    {
        public double a { get; set; }
        public double b { get; set; }
        public double[] c { get; set; }

        public double min()
        {
            if (a < b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        public double max()
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        public double minArr()
        {
            double d = c[0];

            if (c.Length == 0)
            {
                throw new InvalidOperationException("Array is empty");
            }

            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] < d)
                {
                    d = c[i];
                }
            }

            return d;
        }

        public double maxArr()
        {
            double d = c[0];

            if(c.Length == 0)
            {
                throw new InvalidOperationException("Array is empty");
            }

            for(int i= 0; i<c.Length;i++) 
            {
                if (c[i] > d)
                {
                    d = c[i];
                }
            }

            return d;
        }

        public double sum()
        {
            double d = 0;

            if(c.Length == 0)
            {
                throw new InvalidOperationException("Array is empty");
            }

            for(int i = 0; i<c.Length; i++)
            {
                d += c[i];
            }

            return d;
        }
    }
}
