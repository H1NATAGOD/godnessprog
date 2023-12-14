namespace ConsoleApp1;

public class Program
{

    static void Main(string[] args)
    {
        List<string> words = new List<string>();
        List<string> words2 = new List<string>();
        words2.Add("Start");    
        words.Add(Console.ReadLine());
        string word; 
            do
             {
                  word = Console.ReadLine();
                 words.Add(word);
             }   
             while (word != "");

                 for (int i = 0; i < words.Count ; i++)
                 {
                     words2.Add(words[i]);
                 }
                 words2.Add("End");
                     for (int i = 0; i <= words2.Count; i++)
                     { 
                         Console.WriteLine($"{words2[i]} ");
                     }
    }
}    