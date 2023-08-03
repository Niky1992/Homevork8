// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreatSpiralArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    int value = 1;
    int top = 0;
    int bottom = rows - 1;
    int left = 0;
    int right = columns - 1;

    while (value <= rows * columns)
    {
        for (int i = left; i <= right && value <= rows * columns; i++)
        {
            array[top, i] = value;
            value++;
        }
        top++;
        for (int i = top; i <= bottom && value <= rows * columns; i++)
        {
            array[i, right] = value;
            value++;
        }
        right--;
        for (int i = right; i >= left && value <= rows * columns; i--)
        {
            array[bottom, i] = value;
            value++;
        }
        bottom--;
        for (int i = bottom; i >= top && value <= rows * columns; i--)
        {
            array[i, left] = value;
            value++;
        }
        left++;
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:00} ");
        }
        Console.WriteLine();
    }
}
int rows = 4;
int columns = 4;
int[,] spiralArray = CreatSpiralArray(rows, columns);
PrintArray(spiralArray);