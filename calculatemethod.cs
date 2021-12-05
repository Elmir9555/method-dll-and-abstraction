using System;
using newlibrary;

namespace calculatemethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 mtd = new Class1();
            Console.WriteLine("iki eded daxil edin..");           
            mtd.Calculate(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));

        }
    }
}
