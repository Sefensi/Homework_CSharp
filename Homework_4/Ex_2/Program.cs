/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/

int number_sum(string number)
{
    int sum = 0;
    int bbb = 0;
    for (int i = 0; i < number.Length; i++)
    {
        int.TryParse(Convert.ToString(number[i]), out bbb);
        sum = sum + bbb;
        Console.WriteLine(bbb);
    }
    return sum;
}
Console.WriteLine("Введите число");
string xxx = Console.ReadLine();
Console.WriteLine($"Сумма цифр числа равна {number_sum(xxx)}");

