/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3

вводим через один Enter (разбиваем через Split())*/
int counting_more_than_zero(string[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
    
        if (Convert.ToInt32(numbers[i]) > 0)
        {
            count += 1;
        }
    }
    return count;
}
Console.WriteLine("Введите строку");
string spliter = ", ";
string[] splitted_massive = Console.ReadLine().Split(spliter);
Console.WriteLine(counting_more_than_zero(splitted_massive));


