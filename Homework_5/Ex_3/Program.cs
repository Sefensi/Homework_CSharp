// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

//инициализируем массив
double[] InitArray(int dimension, int from, int to)
{
    double[] arr = new double[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        arr[i] = rnd.Next(from, to);
    }

    return arr;
}



//печатаем массив
void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }

    Console.WriteLine();
}

//находим минимальный элемент массива
double GetMinElement(double[] array, int ReadTo)
{
    double min = ReadTo;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
    }

    return min;
}

//находим максимальный элемент массива
double GetMaxElement(double[] array, int ReadFrom)
{
    double max = ReadFrom;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
    }

    return max;
}


//находим разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Введите нижню границу чисел массива");
int ReadFrom = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите верхнюю границу чисел массива");
int ReadTo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите длину массива");
double[] array = InitArray(Convert.ToInt32(Console.ReadLine()), ReadFrom, ReadTo);
PrintArray(array);
double result = GetMaxElement(array, ReadFrom) - GetMinElement(array, ReadTo);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {result}");

