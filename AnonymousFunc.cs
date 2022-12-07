using System;

namespace AnonymousMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> Add = delegate (int firstNum, int secondNum)
              {
                  return firstNum + secondNum;         
              };

            Func<int, int, int> Diff = delegate (int firstNum, int secondNum)
            {
                return firstNum - secondNum;
            };

            Func<int, int, int> Mul = delegate (int firstNum, int secondNum)
            {
                return firstNum * secondNum;
            };

            Func<int, int, int> Div = delegate (int firstNum, int secondNum)
            {
                return firstNum / secondNum;
            };

            Console.WriteLine(Add(10,20));
            Console.WriteLine(Diff(40,20));
            Console.WriteLine(Mul(80,20));
            Console.WriteLine(Div(40,20));
            
        }
    }
}
