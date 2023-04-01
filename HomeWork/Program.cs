// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] FillArray()
{
    System.Console.Write("Введите кол-во строк массива: ");
    int m = int.Parse(Console.ReadLine()!);
    System.Console.Write("Введите кол-во столбцов массива: ");
    int n = int.Parse(Console.ReadLine()!);
    int[,] Array = new int[m, n];
    for (int i = 0; i < Array.GetLength(0); i++)
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = new Random().Next(1, 10);
        }
    return Array;
}

void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}


void MultiplyArrays(int[,] arr1, int[,] arr2)
{
    while (true)
    {
        if (arr1.GetLength(0) == arr2.GetLength(1))
        {
            int[,] arr3 = new int[arr1.GetLength(0), arr2.GetLength(1)];
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    arr3[i, j] = 0;
                    for (int k = 0; k < arr1.GetLength(1); k++)
                    {
                        arr3[i, j] += arr1[i, k] * arr2[k, j];
                    }
                }
            }
            System.Console.WriteLine();
            PrintArray(arr3);
            break;
        }
        else
        {
            System.Console.WriteLine("Введены неверные размеры матриц!!!");
            break;
        }
    }
}

int[,] arr1 = FillArray();
PrintArray(arr1);
System.Console.WriteLine();
int[,] arr2 = FillArray();
PrintArray(arr2);
System.Console.WriteLine();
MultiplyArrays(arr1, arr2);















