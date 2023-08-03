// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] MatrixMultiplication(int[,] matrixFirst, int[,] matrixSecond)
{
    int[,] matrixResult = new int[matrixFirst.GetLength(0), matrixSecond.GetLength(1)];

    for (int i = 0; i < matrixFirst.GetLength(0); i++)
    {
        for (var j = 0; j < matrixSecond.GetLength(1); j++)
        {
            for (int k = 0; k < matrixFirst.GetLength(1); k++)
            {
                matrixResult[i, j] += matrixFirst[i, k] * matrixSecond[k, j];
            }
        }
    }
    return matrixResult;
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

void PrintTwoArrays(int[,] array1, int[,] array2)
{
    int rows = Math.Max(array1.GetLength(0), array2.GetLength(0));
    int columns1 = array1.GetLength(1);
    int columns2 = array2.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns1; j++)
        {
            if (i < array1.GetLength(0))
            {
                Console.Write(array1[i, j] + " ");
            }
            else
            {
                Console.Write("  ");
            }
        }
        Console.Write("| ");
        for (int j = 0; j < columns2; j++)
        {
            if (i < array2.GetLength(0))
            {
                Console.Write(array2[i, j] + " ");
            }
            else
            {
                Console.Write("  ");
            }
        }

        Console.WriteLine();
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

int rowsValueMatrixFirst = GetInfo("Введите количество элементов строки в первой матрице: ");
int rowsValueMatrixSecond = GetInfo("Введите количество элементов строки во второй матрице: ");
int columnsValueMatrixFirst = GetInfo("Введите количество элементов столбцов в первой матрице: ");
int columnsValueMatrixSecond = GetInfo("Введите количество элементов столбцов во второй матрице: ");
if (columnsValueMatrixFirst != rowsValueMatrixSecond) Console.WriteLine("Данная операция не возможна, не верно введины размеры матриц.");
else
{
    int minValue = GetInfo("Введите минимальное число элемента матриц: ");
    int maxValue = GetInfo("Введите максимальное число элемента матриц: ");
    int[,] matrixFirst = DoDoubleArray(rowsValueMatrixFirst, columnsValueMatrixFirst, minValue, maxValue);
    int[,] matrixSecond = DoDoubleArray(rowsValueMatrixSecond, columnsValueMatrixSecond, minValue, maxValue);
    int[,] matrixResult = MatrixMultiplication(matrixFirst, matrixSecond);
    PrintTwoArrays(matrixFirst, matrixSecond);
    Console.WriteLine("Результирующая матрица будет:");
    PrintDoubleArray(matrixResult);
}
