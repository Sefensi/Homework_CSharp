/*Задача 36: 
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/


//инициализируем массив
int[] InitArray(int dimension, int from, int to)
{
int[] arr = new int[dimension];
Random rnd = new Random();

for (int i = 0; i < dimension; i++)
{
arr[i] = rnd.Next(from, to);
}

return arr;
}



//печатаем массив
void PrintArray(int[] arr)
{
for (int i = 0; i < arr.Length; i++)
{
Console.Write($"{arr[i]} ");
}

Console.WriteLine();
}

//находим ceмму элементов на нечетных позициях
int GetNotEvenNumbersSum(int[] array)
{
int sum = 0;

for (int i = 0; i < array.Length; i++)
{
if(array[i] % 2 != 0)
sum += array[i];
}

return sum;
}
Console.WriteLine("Введите нижню границу чисел массива");
int ReadFrom = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите верхнюю границу чисел массива");
int ReadTo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите длину массива");
int[] array = InitArray(Convert.ToInt32(Console.ReadLine()), ReadFrom, ReadTo);
PrintArray(array);
Console.WriteLine($"Количество четных чисел массива = {GetNotEvenNumbersSum(array)}");