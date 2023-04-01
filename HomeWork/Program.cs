// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

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

void CheckCountNum(int[,] Array)
{
    int[] arr = new int[Array.GetLength(0) * Array.GetLength(1)];
    for (int n = 0; n < Array.GetLength(0) * Array.GetLength(1); n++)
    {
        for (int i = 0; i < Array.GetLength(0); i++)
        {
            for (int j = 0; j < Array.GetLength(1); j++)
            {
                arr[n] = Array[i, j];
                n++;
            }
        }
    }
    int[] countArr = new int[10];
    foreach (int num in arr)
    {
        countArr[num]++;
    }

    for (int i = 0; i < countArr.Length; i++)
    {
        if (countArr[i] > 0)
        {
            Console.WriteLine($"{i} встречается {countArr[i]} раз(а)");
        }
    }
}

int[,] Array = FillArray();
PrintArray(Array);
System.Console.WriteLine();
CheckCountNum(Array);











