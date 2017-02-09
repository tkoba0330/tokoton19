using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tokoton19_01
{
    class A
    {
        public void CountUp(B b)
        {
            b.x++;
        }
    }

    class B
    {
        internal int x;
        public void ShoeMe1()
        {
            new A().CountUp(this);
            Console.WriteLine(x);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            new B().ShoeMe1();
        }
    }
}
