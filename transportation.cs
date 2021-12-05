using System;
namespace ierarxiyaabstract
{
    public abstract class transportation
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string color { get; set; }
        public int Door { get; set; }



        public abstract void WheelCount();
        public  void Doorcount()
        {
            Console.WriteLine($"qapi sayi:{Door}");

        }
        

        
    }
}
