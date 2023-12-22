namespace ConsoleApp1;

public class Program
{
   static void Main()
   {
      
      {
         string path = "../../../input.txt";

         string data = File.ReadAllText(path);
         int[] height = data.Split(' ').Select(int.Parse).ToArray();
         int res1 = 0;
         int res2 = 0;
         int Index = 0;
         int Index2 = 0;
         int j = 0;

         for (int i = 0; i < height.Length; i++)
         {
            while (j < height.Length - 1) 
            {
               j++;
               if (i == j)
               {
                  continue;
               }
                
               if (height[i] < height[j])
               {
                  res2 = height[i] * (j - i);
               }
               else                 {
                  res2 = height[j] * (j - i);
               }

               if (res2 > res1)
               {
                  Index = i;
                  Index2 = j;
                  res1 = res2;
               } 
                
            }
            j = i + 1;
         }
        
         Console.WriteLine($"Index1:{Index} index2: {Index2}");
         Console.WriteLine($"Объём воды равен: {res1}");
      }
   }
}