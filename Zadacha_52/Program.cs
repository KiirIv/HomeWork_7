/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.WriteLine("Введите количество строк массива");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] array = new int[m, n];
Random rnd = new Random();

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            array[i, j] = Convert.ToInt32(rnd.Next(0, 10));
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Middle(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        double sum = 0;
        double s = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            sum += arr[j, i];
            s = sum / arr.GetLength(0);
        }
        Console.WriteLine($"Сумма в {i} колонке {sum} , среднеарифметическое равно {Math.Round(s, 1)}");
    }

}

PrintArray(array);
Console.WriteLine();
Middle(array);