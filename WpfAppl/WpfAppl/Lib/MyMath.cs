using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppl.Lib
{
    public class MyMathRenamed
    {
        public float DivFloat(float a, float b)
        {
            return a / b;
        }
        public float MinusFloat(float a, float b)
        {
            return a - b;
        }

        public float AddFloat(float a, float b)
        {
            return a + b;
        }
        public float MulFloat(float a, float b)
        {
            return a * b;
        }
        public float Pow(float x, float y)
        {
            return (float)Math.Pow(x, y);
        }

    }
}
