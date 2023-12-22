namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "../../../numsTask5.txt";
            string data = File.ReadAllText(path);
            int[] nums = data.Split(' ').Select(int.Parse).ToArray();

            int max = nums[0];
            int maxIndex = 0;
            int min = nums[0];
            int minIndex = 0;
            int srsum = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                    maxIndex = i;
                }
                else if (nums[i] < min)
                {
                    min = nums[i];
                    minIndex = i;
                }
            }

            if (minIndex > maxIndex)
            {
                (maxIndex, minIndex) = (minIndex, maxIndex);
            }

            for (int i = minIndex + 1; i < maxIndex; i++)
            {
                srsum += nums[i];
                Console.WriteLine(nums[i]);
            }

           int srproiz = srsum / (maxIndex - minIndex - 1);

            Console.WriteLine($"srproiz is {srproiz}");
        }
    }
}
