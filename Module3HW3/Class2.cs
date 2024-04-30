using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW3
{
    public delegate bool MultiplyDeligate(int x, int y);
    internal class Class2
    {
        private int _result;
        public Func<int, bool> Calc(MultiplyDelegate multiplyFunc, int x, int y)
        {
            _result = multiplyFunc(x, y);
            return Result;
        }
        
        public bool Result(int x)
        {
            Console.WriteLine("Result: {0}", _result % x);
            return _result % x == 0;
        }
    }
}
