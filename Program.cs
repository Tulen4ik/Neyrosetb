using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();   
            int ret;
            int[] array = new int[140];
            List<int> numbers = new List <int>();
            for (int i = 0; i < 140; i++)
            {
                ret = ran.Next(-100, 100);
                array[i] = ret;
                numbers.Add(ret);
                Console.WriteLine(array[i] + " " + numbers[i]);
                Console.ReadKey ();
            }
            int[,] numbers1 = new int[5,5];
            numbers1 [1, 2] = 0;


        }
    }
}
