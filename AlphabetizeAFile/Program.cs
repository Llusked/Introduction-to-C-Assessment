using System;
using System.IO;

namespace AIE
{
    class Program
    {
        public static void Main()
        {
            using (StreamReader reader = new StreamReader("word.txt"))
            {
                while(reader.EndOfStream == false)
                {
                    string line = reader.ReadLine();
                    Console.WriteLine(line);
                }
            }
        }
    }

}