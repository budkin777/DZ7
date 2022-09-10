// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

double[,] arrDouble = new double[m, n];

double[,] FillArray(double[,] arrayDouble)
{
    for (int i = 0; i < arrayDouble.GetLength(0); ++i)
    {
        for (int j = 0; j < arrayDouble.GetLength(1); j++)
        {
            arrayDouble[i, j] = new Random().NextDouble() * 100;
            arrayDouble[i, j] = Math.Round(arrayDouble[i, j], 2);
        }
    }
    return arrayDouble;

}

void PrintArray(double[,] arrayDouble)
{
    for (int i = 0; i < arrayDouble.GetLength(0); ++i)
    {
        for (int j = 0; j < arrayDouble.GetLength(1); j++)
        {
            Console.Write($"{arrayDouble[i, j]}, ");
        }
        Console.WriteLine();
    }
}

FillArray(arrDouble);
PrintArray(arrDouble);