// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] FillArray()
{
    System.Console.Write("Введите кол-во строк массива: ");
    int m = int.Parse(Console.ReadLine()!);
    System.Console.Write("Введите кол-во столбцов массива: ");
    int n = int.Parse(Console.ReadLine()!);
    int[,] Array = new int[m, n];
    int row = 0;
    int column = 0;
    int path = 0;

    for (int i = 1; i <= m * n; i++)
    {
        Array[row, column] = i;

        if (path == 0 && (column == n - 1 || Array[row, column + 1] != 0)) path = 1;
        else if (path == 1 && (row == m - 1 || Array[row + 1, column] != 0)) path = 2;
        else if (path == 2 && (column == 0 || Array[row, column - 1] != 0)) path = 3;
        else if (path == 3 && (row == 0 || Array[row - 1, column] != 0)) path = 0;

        if (path == 0) column++;
        else if (path == 1) row++;
        else if (path == 2) column--;
        else if (path == 3) row--;

        if (Array[row, column] == 0) Array[row, column] = i;
    }
    return Array;
}

void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            if (Array[i,j]<10) Console.Write($"0{Array[i, j]} ");
            else Console.Write($"{Array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int[,] Array = FillArray();
PrintArray(Array);



