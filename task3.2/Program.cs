namespace ConsoleApp1;

public class Program
{
    static void Main()
    {
        List<int> nums = new List<int>();
        using (StreamReader reader = new StreamReader("nums.txt"))
        {
            string numsString = reader.ReadLine() ?? string.Empty; 
            nums = numsString.Split(' ').Select(int.Parse).ToList();
        }
               
        for (int i = 0; i < nums.Count; i++)
        {
            if (nums[i] % 2 == 0)
            {
                nums.RemoveAt(i);
                i--;
            }
        }

        foreach (int num in nums)
        {
            Console.WriteLine(num);
        }

        using (StreamWriter writer = new StreamWriter("nums2.txt"))
        {
            foreach (int num in nums)
            {
                writer.WriteLine(num);
            }
        }
    }
}

