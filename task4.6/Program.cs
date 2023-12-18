namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("numsTask6.txt"))
            {
                Console.WriteLine("Stop the program if it does not have x0 and y0 in the form x0;y0");
                string line = reader.ReadLine();
                string[] nums = line.Split(';');
                reader.Close();
                double x0 = double.Parse(nums[0]);
                double y0 = double.Parse(nums[1]);
                double x1 = -2;
                double x2 = 2;
                double x3 = 0;
                double y1 = -3;
                double y2 = -3;
                double y3 = 2;
                double determinant1 = (x1 - x0) * (y2 - y1) - (x2 - x1) * (y1 - y0);
                double determinant2 = (x2 - x0) * (y3 - y2) - (x3 - x2) * (y2 - y0);
                double determinant3 = (x3 - x0) * (y1 - y3) - (x1 - x3) * (y3 - y0);

                if (determinant1 >= 0 && determinant2 >= 0 && determinant3 >= 0)
                {
                    Console.WriteLine($"The point with coordinates ({x0}; {y0}) belongs to the shaded area.");
                }
                else
                {
                    Console.WriteLine($"The point with coordinates ({x0}; {y0}) does not belong to the shaded area.");
                }
                
            }
        }
    }
}