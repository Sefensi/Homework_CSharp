/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16 
*/


double stepen()
{
    int number_a = 0;
    int number_b = 0;
    while (true)
    {
         Console.WriteLine("Введите А");
        if (int.TryParse(Console.ReadLine(), out number_a) && number_a >= 1)
        {
             Console.WriteLine("Введите B");
            if (int.TryParse(Console.ReadLine(), out number_b) && number_b >= 1)
            {
                break;
            }
            else
            {
                Console.WriteLine("Введено не то число, либо оно не является натуральным");
            }
        }
        else
        {
            Console.WriteLine("Введено не то число, либо оно не является натуральным");
        }
    }
    return Math.Pow(number_a, number_b);
}
Console.WriteLine($"Результат равен {stepen()}");