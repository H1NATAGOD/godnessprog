namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("numsTask1.txt"))
            {
                string line = reader.ReadLine();
                string[] words = line.Split(' ');

                for (int i = 0; i < words.Length; i++)
                {
                    string word = words[i];
                    if (word.Length % 2 != 0)
                    {
                        Console.WriteLine(word);
                    }
                }
            }
        }
    }
}