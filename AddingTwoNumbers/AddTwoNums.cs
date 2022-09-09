using System;

namespace AIE
{
    class AddTwoNums
    {   
          static void Main()
          {
            Console.WriteLine("The Adding of Two Numbers");
            Console.WriteLine(" ");
            Console.WriteLine("First Number");
            string pickFirst = Console.ReadLine();
            int[] num = new int [2];
            _ = int.TryParse(pickFirst, out num[0]);

            Console.WriteLine("Second Number");
            pickFirst = Console.ReadLine();
            _ = int.TryParse(pickFirst, out num[1]);
            int sum = num[0] + num[1];
            Console.WriteLine((float)sum);
        }
    }
}
