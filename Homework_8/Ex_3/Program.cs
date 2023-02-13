/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

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

int[,] GetMatrixMultiply(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix3 = new int[matrix1.GetLength(0),matrix1.GetLength(0)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(0); k++)
            {
                {
                    matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
    }
    return matrix3;
}



Console.WriteLine("Введите размерность квадратной матрицы");
int count = Convert.ToInt32(Console.ReadLine());

int[,] matrix1 = InitMatrix(count, count);
int[,] matrix2 = InitMatrix(count, count);
int[,] matrix3 = GetMatrixMultiply(matrix1, matrix2);

PrintMatrix(matrix1);
Console.WriteLine();
Console.WriteLine();
PrintMatrix(matrix2);
Console.WriteLine();
Console.WriteLine();
PrintMatrix(matrix3);
