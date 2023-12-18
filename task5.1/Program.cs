namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("numsTask1.txt"))
            {
                string line = reader.ReadLine();
                string[] nums = line.Split(' ');
                reader.Close();
                int min = int.MaxValue;
                int sum = 1;
                int index = 0;

                for (int i = 0; i < nums.Length - 1; i++)
                {
                    int num = int.Parse(nums[i]);
                    if (num < min)
                    {
                        index = i; 
                        min = num;
                    }
                }
                for (int i = 0; i < nums.Length; i++)
                {
                    int num2 = int.Parse(nums[i]);
                    if (i > index)
                    {
                        sum *= num2;
                    }
                }
                Console.WriteLine($"Minimal number: {min}");
                Console.WriteLine($"Sum of numbers after the minimum: {sum}");
            }
        }
    }
}
                