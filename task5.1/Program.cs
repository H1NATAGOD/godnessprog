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

                    if (num > min) 
                    {
                        sum += num; 
                    }
                }
                Console.WriteLine($"Sum {min} is {sum} ");
            }
        }
    }
}
                