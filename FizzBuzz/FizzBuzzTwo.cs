using System;

namespace AIE
{
    class FizzBuzzTwo
    {
        public static void Main(List<int> arr)
        {
            Console.WriteLine("This is Fizz Buzz");
            //bool isRunning = true;
            //int num = 0;
            Console.ReadLine();

            for (int i = 0; i < arr.Count; i++)
            {
                //num = i;
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            
        }

    }

}
