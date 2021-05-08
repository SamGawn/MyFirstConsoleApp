using System;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //OperatorExample();
            //LoopThree();
            TryAnIf();

        }

        private static void OperatorExample()
        {
            int width = 3;
            width++;
                        
            int height = 2 + 4;
            int area = width * height;
            Console.WriteLine(area);
            
            string result = "The area";
            result = result + " is " + area;
            Console.WriteLine(result);
            
            bool truthValue = true;
            Console.WriteLine(truthValue);
        }

        private static void LoopThree()
        {
            int p = 2;
            for (int q = 2; q < 32; q = q * 2)
            {
                while (p < q)
                {
                    p = p * 2;
                }
                q = p - q;
            }
        }

        private static void TryAnIf()
        {
            int someValue = 4;
            string name = "Bobbo Jr.";
            if ((someValue ==3) && (name == "Joe"))
            {
                Console.WriteLine("x is 3 and the name is Joe");
            }
            Console.WriteLine("this line runs no matter what");
        }
    }
}
