namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();

            using (StreamReader reader = new StreamReader("numsTask2.txt"))
            {
                string line = reader.ReadLine();
                string[] numsStr = line.Split(';');
                
                for (int i = 0; i < numsStr.Length; i++)
                {
                    nums.Add(int.Parse(numsStr[i]));
                }

                nums.Sort();
            }

            string sortedNumsStr = string.Join(";", nums);

            using (StreamWriter writer = new StreamWriter("numsTask2.txt"))
            {
                writer.Write(sortedNumsStr);
            }

            Console.WriteLine("Числа были успешно отсортированы и записаны обратно в файл.");
        }
    }
}