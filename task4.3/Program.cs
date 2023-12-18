namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("numsTask3.txt"))
            {
                string line = reader.ReadLine();
                string[] nums = line.Split(',');
                reader.Close();

                int max = int.Parse(nums[0]);
                int min = int.Parse(nums[0]);
                for (int i = 0; i < nums.Length; ++i)
                {
                    int value = int.Parse(nums[i]);
                    
                    if (value == 0) 
                    {
                        break;
                    }
                    
                    if (value < min)
                    {
                        min = value;
                    }


                    if (value > max)
                    {
                        max = value;
                    }
                }


                int result = max - min;
                
                Console.WriteLine($"Resalt is {result}");
            }
        }
    }
}