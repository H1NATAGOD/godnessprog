namespace ConsoleApp1;

public class Program
{
    static void Main(string[] args)
    {
        int[] nums = new int[10];
        Random rand = new Random();
        int min = nums[0];
        int Index = 0; 
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = rand.Next();
        }
        Console.WriteLine($"Array is:");
        for (int i = 0; i < nums.Length; i++)
        {
            Console.WriteLine($"{nums[i]}");
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < min)
            {
                Index = i;
                min = nums[i];
            }
        }
        Console.WriteLine($"Min nums of this array is {Index} ");
    }
}
            
             
