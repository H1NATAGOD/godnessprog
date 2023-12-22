namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[,] nums = new int[n, m];
            int[] count = new int[n];
            int sum = 0;
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    nums[i, j] = rnd.Next(0, 2);
                    Console.Write($"{nums[i, j]} \t");
                    sum += nums[i, j];
                }

                if (sum % 2 != 0)
                {
                    count[i] = 1;
                }

                sum = 0;

                Console.WriteLine(count[i]);
                Console.WriteLine();
            }
        }
    }
}