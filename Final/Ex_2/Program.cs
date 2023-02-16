/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int GetNaturalNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.Write(message);

        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число или некорректное число. Повторите ввод!");
        }
    }

    return result;
}

int GetSum(int N, int M)
{
    if (N == M)
    {
        return N;
    }
    return GetSum(N + 1, M) + N;
}

Console.WriteLine();
int N = GetNaturalNumber("Введите N: ");
int M = GetNaturalNumber("Введите M: ");

if (N > M)
{
    Console.WriteLine(GetSum(M, N));
}
else
{
    Console.WriteLine(GetSum(N, M);
}

