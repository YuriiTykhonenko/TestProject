using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole2
{
    public class TestString
    {

        public static string GetSomeText(int value) {
            return String.Format("Number is :{0}", value);
        }
    }
}
