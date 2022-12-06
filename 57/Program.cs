// 57. Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество строк массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(rows, columns, 0, 10);
int[] repeatElem = RepeatElements(array);

PrintArray(array);
Console.WriteLine($"============================");
PrintArray1(repeatElem);

//=======================================================

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void PrintArray1(int[] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        if (inArray[i] != 0)
        {
            Console.Write($"Число {i} повторяется {inArray[i]} количество раз!\n");
        }

    }
}

int[] RepeatElements(int[,] arr)
{св
    int[] RepeatTable = new int[10];
    for (int i = 0; i < RepeatTable.Length; i++)
    {
        int sum = 0;
        foreach (int var in arr)
        {
            if (i == var)
            {
                sum++;
            }
            RepeatTable[i] = sum;
        }
    }

    return RepeatTable;
}