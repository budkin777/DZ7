// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
Console.WriteLine("Введите размер массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int [,] arr = new int [m,n];
Console.WriteLine("Введите позицию элемента: ");
int line_position = Convert.ToInt32(Console.ReadLine());
int column_position = Convert.ToInt32(Console.ReadLine());

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

int temp = -1; 
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int k = 0; k < arr.GetLength(1); k++)
    {
        if ( i == line_position && k == column_position) temp = arr[i,k]; 
    }    
}
if (temp == -1) Console.WriteLine("Такого элемента нет");
else Console.WriteLine("Такой элемент присутствует");

