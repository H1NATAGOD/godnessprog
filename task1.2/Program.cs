namespace ConsoleApp1;

public class Program
{

    static void Main(string[] args)
    {
        int sum = 0;
        int numb;
        Console.WriteLine($"Get number, They you get 0 sum end");
        do
        {
            numb = int.Parse(Console.ReadLine());
            sum += numb;
        } while (numb != 0);
      Console.WriteLine($"Sum is {sum}");
    }
}    