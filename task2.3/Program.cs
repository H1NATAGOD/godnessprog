namespace ConsoleApp1;

 public class Program
{
    static void Main()
    {
        Console.Write("Введите размерность матрицы: ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];

        // Заполнение первой строки и первого столбца значением 1
        for (int i = 0; i < n; i++)
        {
            matrix[i, 0] = 1;
            matrix[0, i] = 1;
        }

        // Заполнение остальных элементов матрицы
        for (int i = 1; i < n; i++)
        {
            for (int j = 1; j < n; j++)
            {
                matrix[i, j] = matrix[i - 1, j] + matrix[i, j - 1];
            }
        }

        // Вывод матрицы на экран
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
} 