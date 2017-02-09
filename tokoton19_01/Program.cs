using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tokoton19_01
{
    class A
    {
        public void CountUp(ref int y)
        {
            y++;
        }
    }

    class B
    {
        private int x;
        public void ShoeMe1()
        {
            x = 0;
            new A().CountUp(ref x);
            Console.WriteLine(x);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            new B().ShoeMe1();

            Console.ReadLine();
        }
    }
}
