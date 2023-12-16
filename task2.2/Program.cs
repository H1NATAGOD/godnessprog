namespace ConsoleApp1;

public class Program
{
    static void Main(string[] args)
    { 
        Console.Write("Set the number of numbers in the array: ");
        int numb = int.Parse(Console.ReadLine());
        int[] nums = new int[numb];
        for (int i = 1; i <= numb; i++)
        {
            if (i % 2 != 0)
            {
                nums[i] = i ;
               
            }
            Console.WriteLine($"нечётное число массива {nums[i]}");
        }
    }
}   