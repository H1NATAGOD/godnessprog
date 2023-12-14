namespace ConsoleApp1;

public class Program
{

    static void Main(string[] args)
    {
        List<string> words = new List<string>();
        words.Add(Console.ReadLine());
        string word;
        int min = words[0].Length;
        int Index1 = 0;
        int max = words[0].Length;
        int Index2 = 0;
        do
        {
            word = Console.ReadLine();
            words.Add(word);
        } 
        while (word != "");
        
        
        for(int i = 0; i < words.Count - 1; i++)
            if (words[i].Length < min)
            {
                Index1 = i + 1;
                min = words[i].Length;
            }

        Console.WriteLine($"Min word: {Index1}");
        for(int i = 0; i < words.Count - 1; i++)
            if (words[i].Length >= max)
            {
                Index2 = i + 1;
                max = words[i].Length;
            } 
        Console.WriteLine($"Max word: {Index2}");
    }
}    