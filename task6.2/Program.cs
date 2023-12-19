namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = File.ReadAllLines("../../../numsTask2.txt");
            string fString = string.Join(" ", words);
            Console.WriteLine(fString); 
        }
    }
}