namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Enter a positive number, if it is negative, the program will end");
        int sum = 0;
        List<int> nums = new List<int>();
            
        nums.Add(int.Parse(Console.ReadLine()));
        int numb;
        int posnumb;
        do
        {
            numb = int.Parse(Console.ReadLine());
            nums.Add(numb);
        }   
        while (numb > 0 );

        for (int i = 0; i < nums.Count; i++)
        {
            posnumb = nums[i];
            sum += posnumb;
        }
        Console.WriteLine($"The sum of positive numbers is: {sum}");

        }
    }
}