namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("numsTask3.txt"))
            {
                string line = reader.ReadLine();
                string[] nums = line.Split(' ');
                reader.Close();
                int min = int.MaxValue;
                int sum = 0;
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
                        sum += num2;
                    }
                }
                int count = nums.Length - index - 1;
                double average = sum / (double)count;

                Console.WriteLine($"Minimal number: {min}");
                Console.WriteLine($"Sum of numbers after the minimum: {sum}");
                Console.WriteLine($"Arithmetic mean of numbers after the minimum: {average}");
            }
        }
    }
}