// Задача 50: Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого числа в массиве нет

Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
        result[i, j] = new Random().Next(minValue, maxValue + 1);
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


Console.Write("Введите первую позицию в двумерном массиве: ");
int position1 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите вторую позицию в двумерном массиве: ");
int position2 = int.Parse(Console.ReadLine() ?? "");
FindPosition(array, position1, position2, rows, columns);

void FindPosition(int[,] array, int position1, int position2, int rows, int columns)
{
    if(position1>(rows-1) || (position2>(columns-1))) 
    {
        Console.WriteLine("такого числа в массиве нет"); 
        return;
    }
    Console.WriteLine($"{array[position1, position2]} ");
}


