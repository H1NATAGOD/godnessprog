namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("numsTask4.txt"))
            {
                string line = reader.ReadLine();
                string[] nums = line.Split(' ');
                reader.Close();
                int max = int.MinValue;
                int sum = 0;
                int index = 0;

                for (int i = 0; i < nums.Length - 1; i++)
                {
                    int num = int.Parse(nums[i]);
                    if (num > max)
                    {
                        index = i;
                        max = num;
                    }
                    
                }

                for (int i = 0; i < nums.Length; i++)
                {
                    int num2 = int.Parse(nums[i]);
                    if (max - 1 == num2)
                    {
                        sum += num2;
                    }
                }
              

                Console.WriteLine($"Maximal number: {max}");
                Console.WriteLine($"Sum of numbers differing from the maximum by 1: {sum}");
                
            }
        }
    }
}