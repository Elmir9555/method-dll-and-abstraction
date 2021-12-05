using System;

namespace ierarxiyaabstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Bus trn = new Bus();
            trn.WheelCount();
            trn.Door = 2;
            trn.Doorcount();
            trn.Brand = "Daewo";
            trn.Model = "Bs-106";
            trn.color = "Red";
            Console.WriteLine($"Brand:{trn.Brand}  Model:{trn.Model}  Color:{trn.color}");
        }
    }
}
