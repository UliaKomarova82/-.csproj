// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

задача 1

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] randomArray = new double[m, n];

// Заполнение массива случайными значениями
void FillArray(int m, int n)
{
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            randomArray[i, j] = rand.NextDouble();
        }
    }
}

// Получение значения элемента
Console.Write("Введите номер строки: ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Значение элемента: {randomArray[m2, n2]}");

задача 3
using System;

class Program
{
    static void Main()
    {
        int[][] matrix = new int[][]
        {
            new int[] {1, 2, 3},
            new int[] {4, 5, 6},
            new int[] {7, 8, 9}
        };

        int minSum = int.MaxValue;
        int[] minSumRow = null;

        foreach (int[] row in matrix)
        {
            int rowSum = 0;
            foreach (int num in row)
            {
                rowSum += num;
            }
            if (rowSum < minSum)
            {
                minSum = rowSum;
                minSumRow = row;
            }
        }

        Console.WriteLine("Строка с наименьшей суммой элементов:");
        foreach (int num in minSumRow)
        {
            Console.Write(num + " ");
        }
    }
}
Задача 2

using System;

class Program
{
    static void Main()
    {
        int[,] array = new int[,]
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        // Меняем местами первую и последнюю строку
        for (int i = 0; i < cols; i++)
        {
            int temp = array[0, i];
            array[0, i] = array[rows - 1, i];
            array[rows - 1, i] = temp;
        }

        // Выводим измененный массив
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
