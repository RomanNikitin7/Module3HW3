using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW3
{
    public delegate void MyShowDelegate(bool b);
    public delegate int MultiplyDelegate(int x, int y);
    public class Class1
    {
        public int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}