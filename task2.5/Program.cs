

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int[]> monthtemp = new Dictionary<string, int[]>();
            Random rndm = new Random();
            monthtemp.Add("january", new int[31]);
            monthtemp.Add("february", new int[28]);
            monthtemp.Add("march", new int[31]);
            monthtemp.Add("april", new int[30]);
            monthtemp.Add("may", new int[31]);
            monthtemp.Add("june", new int[30]);
            monthtemp.Add("july", new int[31]);
            monthtemp.Add("august", new int[31]);
            monthtemp.Add("september", new int[30]);
            monthtemp.Add("october", new int[31]);
            monthtemp.Add("november", new int[30]);
            monthtemp.Add("december", new int[31]);

            for (int i = 0; i < monthtemp.Count; i++)
            {
                string key = monthtemp.Keys.ElementAt(i);
                int[] temperatures = monthtemp[key];
                for (int j = 0; j < temperatures.Length; j++)
                {
                    if (key == "january" || key == "february" || key == "december")
                    {
                        temperatures[j] = rndm.Next(-30, -3);
                    }
                    else if (key == "june" || key == "july" || key == "august")
                    {
                        temperatures[j] = rndm.Next(15, 30);
                    }
                    else
                    {
                        temperatures[j] = rndm.Next(-7, 15);
                    }
                }
            }

            Dictionary<string, int> averageTemperatures = CalculateAverageTemperatures(monthtemp);

            Console.Write("Write the name of the month: ");
            string inputMonth = Console.ReadLine().ToLower();

            if (averageTemperatures.ContainsKey(inputMonth))
            {
                Console.WriteLine($"Average temprature in {inputMonth}: {averageTemperatures[inputMonth]}");
            }
            else
            {
                Console.WriteLine("Sorry this month don't found ");
            }
        }

        static Dictionary<string, int> CalculateAverageTemperatures(Dictionary<string, int[]> temperature)
        {
            Dictionary<string, int> averageTemperatures = new Dictionary<string, int>();
            for (int i = 0; i < temperature.Count; i++)
            {
                string key = temperature.Keys.ElementAt(i);
                int[] temperatures = temperature[key];
                int sum = 0;
                for (int j = 0; j < temperatures.Length; j++)
                {
                    sum += temperatures[j];
                }
                int average = sum / temperatures.Length;
                averageTemperatures.Add(key, average);
            }
            return averageTemperatures;
        }
    }
}
