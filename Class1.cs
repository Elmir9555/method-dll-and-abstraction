using System;

namespace newlibrary
{
    public class Class1
    {
        public void Calculate(int a,int b)
        {
            int sum = a + b;
            Console.WriteLine($"a+b={sum}");
            int result = a * b;
            Console.WriteLine($"a*b={result}");
            var divide = a / b;
            Console.WriteLine($"a/b={divide}");
            int minus = a - b;
            Console.WriteLine($"a-b={minus}");
        }
        
    
    }
}
