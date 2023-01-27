//Задача 21
/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A(3, 6, 8); B(2, 1, -7), -> 15.84

A(7, -5, 0); B(1, -1, 9)-> 11.53*/
int[] massive(string point)
{
    int[] array = new int[point.Length];
    point = point.Replace(" ", "");
    for (int i = 0; i < point.Length; i++)
    {
        array[i] = Convert.ToInt32(point[i]);
    }
    return array;
}


Console.WriteLine("Введите ax ay az");
string tochka_a = Console.ReadLine();
Console.WriteLine("Введите bx by bz");
string tochka_b = Console.ReadLine();

double chet(string point_a, string point_b)
{
    int[] ch1 = massive(point_a);
    int[] ch2 = massive(point_b);
    double dlina = 0;
    for (int i = 0; i < ch1.Length; i++)
    {
        int otric = ch1[i] - ch2[i];

        dlina = dlina + Math.Pow(otric, 2);

    }

    double koren = Math.Sqrt(dlina);
    return koren;
}

Console.WriteLine(chet(tochka_a,tochka_b));
