namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[,] monthtemp = new int[12, 30];
            Random rndm = new Random();
            int rows = monthtemp.GetLength(0);
            int columns = monthtemp.GetLength(1);

            for (int j = 0; j < columns; j++)
            {
                for (int i = 0; i < rows; i++)
                {
                    if (i == 0 || i ==11 || i == 1)
                    {
                        monthtemp[i, j] = rndm.Next(-30, -3);
                    }
                    else if (i == 5 || i == 7 || i == 6)
                    {
                        monthtemp[i, j] = rndm.Next(15, 30);
                    }
                    else
                    {
                        monthtemp[i, j] = rndm.Next(-7, 15);
                    }
                }
            }

            int[] averageTemperatures = CalculateAverageTemperatures(monthtemp);

            Array.Sort(averageTemperatures);

            Console.WriteLine("Average temperature in month (down to up):");
            for( int i = 0; i < averageTemperatures.Length; i++)
            {
                Console.WriteLine($"Month number { i + 1} is {averageTemperatures[i]}");
            }
        }

        static int[] CalculateAverageTemperatures(int[,] temperature)
        {
            int rows = temperature.GetLength(0);
            int columns = temperature.GetLength(1);
            int[] averageTemperatures = new int[rows];

            for (int i = 0; i < rows; i++)
            {
                int sum = 0;
                for (int j = 0; j < columns; j++)
                {
                    sum += temperature[i, j];
                }
                averageTemperatures[i] = sum / columns;
            }

            return averageTemperatures;
        }
    }
}


