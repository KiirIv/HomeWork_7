/*Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/

double[,] table = new double[3, 4];

void PrintArray(double[,] tab)
{
    for (int i = 0; i < tab.GetLength(0); i++)
    {
        for (int j = 0; j < tab.GetLength(1); j++)
        {
            Console.Write($"{tab[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(double[,] tab)
{
    Random rnd = new Random();
    for (int i = 0; i < tab.GetLength(0); i++)
    {
        for (int j = 0; j < tab.GetLength(1); j++)
        {
            tab[i, j] = Convert.ToDouble(rnd.Next(-100, 100) / 10.0);
        }
    }
}
PrintArray(table);
Console.WriteLine();
FillArray(table);
PrintArray(table);