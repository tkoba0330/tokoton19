using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace tokoton19_02
{
    class A
    {
        public void CountUp(B b)
        {
            var field = b.GetType().GetField("x", BindingFlags.GetField | BindingFlags.SetField | BindingFlags.NonPublic | BindingFlags.Instance);

            field.SetValue(b, (int)(field.GetValue(b)) + 1);
        }
    }


    class B
    {
        private int x;
        public void ShowMe1()
        {
            x = 0;
            new A().CountUp(this);
            Console.WriteLine();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            new B().ShowMe1();

            Console.ReadLine();
        }
    }
}
