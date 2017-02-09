using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tokoton19_01
{
    class A
    {
        public void CountUp(Action<int> setter, Func<int> getter)
        {
            setter(getter() + 1);
        }
    }

    class B
    {
        private int x;
        public void ShoeMe1()
        {
            x = 0;
            new A().CountUp((a) => { x = a; }, () => x);
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
