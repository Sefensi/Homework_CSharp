/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

пользователь вводит индексы 10, 10 - такого элемента нет.
пользователь вводите индексы 0, 2 - выводим элеменет 7*/

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

void FindNumber(int[,] matrix)
{
    Console.WriteLine("Введите первый индекс");
    int first = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второй индекс");
    int second = Convert.ToInt32(Console.ReadLine());

    Console.Write($"{matrix[first, second]} ");
    Console.WriteLine();
}

int countOfRows = 10;
int countOfColumns = 10;
int[,] matrix = InitMatrix(countOfRows, countOfColumns);

FindNumber(matrix);

