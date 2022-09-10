Console.WriteLine("Введите размер массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int [,] arr = new int [m,n];

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10);
        }
    }
    //return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); ++i)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}, ");
        }
        Console.WriteLine();
    }
}

FillArray(arr);
PrintArray(arr);

double sum = 0;
for (int i = 0; i < arr.GetLength(0); ++i)
    {
        sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr [j, i];
        }
        Console.WriteLine(sum / arr.GetLength(0));     
    }
