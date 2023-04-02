// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
int rand()
{
    int a = new Random().Next(10, 100);
    return a;
}

int[,,] FillArray()
{
    System.Console.Write("Введите кол-во строк массива: ");
    int m = int.Parse(Console.ReadLine()!);
    System.Console.Write("Введите кол-во столбцов массива: ");
    int n = int.Parse(Console.ReadLine()!);
    System.Console.Write("Введите глубину массива: ");
    int l = int.Parse(Console.ReadLine()!);
    int[] arr = new int[m * n * l];
    for (int i = 0; i < m * n * l; i++)
    {
        if (m*n*l<=90) break;
        int num;
        arr[i] = rand();
        num = arr[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (arr[i] == arr[j])
                {
                    arr[i] = rand();
                    j = 0;
                    num = arr[i];
                }
                num = arr[i];
            }
        }
    }
    int el = 0;
    int[,,] Array = new int[m, n, l];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            for (int k = 0; k < Array.GetLength(2); k++)
            {
                Array[i, j, k] = arr[el];
                el++;
            }
        }
    }
    return Array;
}




void PrintArray(int[,,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            for (int k = 0; k < Array.GetLength(2); k++)
            {
                Console.Write($"{Array[i, j, k]} ({i},{j},{k}) ");
            }
            System.Console.WriteLine();
        }
    }
}

int[,,] Array3 = FillArray();
PrintArray(Array3);















