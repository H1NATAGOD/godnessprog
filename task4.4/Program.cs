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

                int count = 0;

                for (int i = 0; i < nums.Length - 1; i++)
                {
                    if (nums[i] == nums[i + 1])
                    {
                        count++;
                    }
                    
                }
                Console.WriteLine($"umber of identical numbers is {count}");
            }
        }
    }
}