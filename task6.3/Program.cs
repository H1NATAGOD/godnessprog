namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Get number: ");
            int numb = int.Parse(Console.ReadLine());
            if (numb % 2 == 0 && numb % 10 == 0)
            {
                Console.WriteLine($"Number {numb} even and multiple of 10");
            }
            else if (numb % 2 == 0 && numb % 10 != 0)
            {
                Console.WriteLine($"Number {numb} even, but not a multiple of 10");
            }
            else
            {
                Console.WriteLine($"Number {numb} not even and not a multiple of 10");
            }
        }
    }
}