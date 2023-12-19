
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd1 = new Random();
            int numb = rnd1.Next(5, 20);
            double[] nums = new double[numb];
           
            double[] numsplus = new double[numb];
            double[] numsminus = new double[numb];
            double n1;
            double n2;
          
            int index = 0;
            int index2 = 0;
           
            for (int i = 0; i < numb; i++)
            {
                n1 = rnd1.Next(-20, 20);
                n2 = rnd1.Next(-20, 20);
                
                if (n2 != 0)
                {
                    nums[i] = n1 / n2;
                }
                else
                {
                    nums[i] = 0;
                }

                Console.WriteLine($"{i} nums1 {nums[i]}");
            }

            for (int i = 0; i < numb; i++)
            {
                if (nums[i] < 0)
                {
                    numsminus[index++] = nums[i];
                }
                else if (nums[i] > 0 || nums[i] == 0)
                {
                    numsplus[index2++] = nums[i];
                }
            }

            Console.WriteLine("numsplus:");
            for (int i = 0; i < index2; i++)
            {
                Console.Write(numsplus[i] + " ");
            }

            Console.WriteLine("\nnumsminus:");
            for (int i = 0; i < index; i++)
            {
                Console.Write(numsminus[i] + " ");
            }
        }
    }
}
        
            