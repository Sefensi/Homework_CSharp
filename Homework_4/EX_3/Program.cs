//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

/*1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]*/

Console.WriteLine("Введите максимальный размер каждого числа массива");
int razmer = Convert.ToInt32(Console.ReadLine());
int [] CreateArray()
{
int [] Array = new int [8];
Random number = new Random();
for (int i = 0; i < Array.Length; i++)
{
Array[i] = number.Next(0, razmer);
}
return Array;
}
int [] a = CreateArray();

void PrintArray (int[] array)
{
for (int i = 0; i < array.Length; i++)
{
Console.Write($" {array[i]} ");
}
}
Console.Write($"[");
PrintArray(a);
Console.Write($"]");
