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
            var field = b.GetType().GetProperty("x", BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.NonPublic | BindingFlags.Instance);

            field.SetValue(b, (int)(field.GetValue(b)) + 1, null);
        }
    }


    class B
    {
        private int x { get; set; } = 0;
        public void ShowMe1()
        {
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
