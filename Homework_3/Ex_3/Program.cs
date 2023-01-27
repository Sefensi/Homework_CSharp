//Задача 23

/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.*/
Console.WriteLine("Введите N");
int number = Convert.ToInt32(Console.ReadLine());
string massive = "";
for (int i = 1; i < number + 1; i++)
{
    massive += $"{Math.Pow(i, 3)} ";
}
Console.WriteLine(massive);
