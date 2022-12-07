using System;

namespace AnonymousAction
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int, int> Add = delegate (int firstnum, int secondnum)
             {
                 Console.WriteLine($"The sum is : {firstnum + secondnum}");
             };

            Action<int, int> Diff = delegate (int firstnum, int secondnum)
            {
                Console.WriteLine($"The difference is : {firstnum - secondnum}");
            };

            Action<int, int> Mul = delegate (int firstnum, int secondnum)
            {
                Console.WriteLine($"The product is : {firstnum * secondnum}");
            };

            Action<int, int> Div = delegate (int firstnum, int secondnum)
            {
                Console.WriteLine($"The quotient is : {firstnum / secondnum}");
            };

            Add(10, 20);
            Diff(50, 20);
            Mul(10, 20);
            Div(100, 20);
        }
        
    }
}
