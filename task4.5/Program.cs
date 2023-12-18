namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("numsTask5.txt"))
            {
                string line = reader.ReadLine();
                string[] nums = line.Split(';');
                reader.Close();

                double x1 = -1;
                double x2 = 3;
                double y1 = -2;
                double y2 = 4;
                double a = double.Parse(nums[0]);
                double b = double.Parse(nums[1]);
                bool cool = false;
                bool cool2 = false;

                for (int i = 0; i <= nums.Length; i++)
                {
                    if (i == 0)
                    {
                        if (a > x1 && a < x2)
                        {
                             cool = true;
                        }
                        else
                        {
                            cool = false;
                        }
                    }

                    if (i == 1)
                    {
                        if (b > y1 && b < y2)
                        {
                            cool2 = true;
                        }
                        else
                        {
                            cool2 = false;
                        }
                    }
                }
                if(cool == true && cool2 == true )
                {
                    Console.WriteLine($"a point lying on coordinates ({nums[0]}; {nums[1]}) lies within the square");
                }
                else
                {
                    Console.WriteLine($"a point lying on coordinates ({nums[0]}; {nums[1]}) does not lie with in the square");
                }

            }
        }
    }
}