using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Set a limit for the number of numbers ");
            int numb = int.Parse(Console.ReadLine());
            int[] nums = new int[numb];
            Random rnd1 = new Random();
            Console.WriteLine("Set limits for random numbers, the first number is less than the second");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            for (int i = 0; i < numb; i++)
            {
                nums[i] = rnd1.Next(n1, n2);
            }
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("{0} ", nums[i]);
            }
        }
    }
}  