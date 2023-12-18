namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("numsTask2.txt"))
            {
                string line = reader.ReadLine();
                string[] nums = line.Split(';');
                reader.Close();

                double sum = 0;
                for (int i = 0; i < nums.Length; ++i)
                {
                    double value = double.Parse(nums[i]);
                    if (value == 0)
                    {
                        break;
                    }

                    if (value > 0)
                    {
                        sum = sum + value;
                    }
                }
                Console.WriteLine($"sum is {sum}");
            }
        }
    }
}