namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[100];
            Console.WriteLine("Get number: ");
            int numb = int.Parse(Console.ReadLine());
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = numb;
                numb = numb - 3;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"Number {i} = {nums[i]}");
            }

        }
    }
}