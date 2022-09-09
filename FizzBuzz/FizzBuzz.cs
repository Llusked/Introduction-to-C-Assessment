using System;

namespace AIE
{
    class FizzBuzz
    {
        public static void Main()
        {

            Console.WriteLine("This is Fizz Buzz");

            for (int i = 0; i < 20; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }

                if (i % 3 == 0)
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

         /*List<int> arr*/
         //Console.WriteLine("This is Fizz Buzz");

         //for (int i = 0; i < arr.Count; i++)
         //{
         //    //int num = arr[i];
         //    if (i % 3 == 0 && i % 5 == 0)
         //    {
         //        Console.WriteLine("FizzBuzz");
         //    }
         //    if (i % 3 == 0)
         //    {
         //        Console.WriteLine("Fizz");
         //    }
         //    if (i % 5 == 0)
         //    {
         //        Console.WriteLine("Buzz");
         //    }
         //    else
         //    {
         //        Console.WriteLine(i);
         //    }
         //}

        }

    }

}
