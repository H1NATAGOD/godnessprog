using System.Numerics;
using System.Runtime.InteropServices.JavaScript;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Specify a positive integer: ");
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            
            BigInteger sum = 1;
            for (int i = 1; i <= n; i++)
            {
                if ( i % 3 == 0)
                {
                    sum *= i;
                }
                Console.WriteLine(sum );
            }
            Console.WriteLine($"The product of number is equal to {sum}");
        }
    }
}    