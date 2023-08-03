// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить 
// массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

bool TwoDigitAndNonRepeatingCheck(int number, int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == number) return false;
            }
        }
    }
    return number >= 10 && number <= 99;
}

int[,,] CreateThreeArray(int rows, int columns, int thirdElement, int minValue, int maxValue)
{
    int[,,] array = new int[rows, columns, thirdElement];
    int number = new Random().Next(minValue, maxValue);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                while (!TwoDigitAndNonRepeatingCheck(number, array))
                {
                    number = new Random().Next(minValue, maxValue);
                }
                array[i, j, k] = number;
            }
        }
    }
    return array;
}

void PrintThirdArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{ array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine("");
        }

    }
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int rows = GetInfo("Введите число строк: ");
int columns = GetInfo("Введите число столбцов: ");
int thirdElement = GetInfo("Введите число третьего измерения: ");
int[,,] array = CreateThreeArray(rows, columns, thirdElement, 10, 100);
PrintThirdArray(array);