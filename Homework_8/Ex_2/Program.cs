/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/


int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не корректное число. Повторите ввод.");
        }
    }

    return result;
}

int[,] InitMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }

        Console.WriteLine();
    }
}
int SumOfNumbersInARow(int[,] matrix)
{
    int min_i = 0; 
    int sum = 999;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int ResultInARow = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            ResultInARow = ResultInARow + matrix[i, j];
        }
        if (sum > ResultInARow)
        {
            sum = ResultInARow;
            min_i = i + 1;
        }
    }
    return min_i;
}




int countOfRows = 10;
int countOfColumns = 10;
int[,] matrix = InitMatrix(countOfRows, countOfColumns);

PrintMatrix(matrix);
Console.WriteLine($"Строка с наименьшей суммой чисел: {SumOfNumbersInARow(matrix)}");