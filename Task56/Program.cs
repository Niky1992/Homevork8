//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int MinSumRows(int[,] array)
{
    int minSum = int.MaxValue;
    int minRow = -1;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int currentSum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            currentSum += array[i, j];
        }

        if (currentSum < minSum)
        {
            minSum = currentSum;
            minRow = i;
        }
    }

    return minRow + 1;
}




void PrintDoubleArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine("");
    }
}

int[,] DoDoubleArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


int rows = GetInfo("Введите число строк: ");
int columns = GetInfo("Введите число столбцов: ");
if (rows == columns)
{
    while (rows == columns)
    {
        Console.WriteLine("Вы ввели не прямоугольный массив.");
        rows = GetInfo("Введите число строк: ");
        columns = GetInfo("Введите число столбцов: ");
    }
}
int minValue = GetInfo("Введите минимальное число элемента массива: ");
int maxValue = GetInfo("Введите максимальное число элемента массива: ");
int[,] array = DoDoubleArray(rows, columns, minValue, maxValue);
PrintDoubleArray(array);
Console.WriteLine($"Строка с наименьшей суммой элементов массива: {MinSumRows(array)}");