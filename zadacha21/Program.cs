﻿Console.WriteLine("Введите первое число: ");
double a = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
double b = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число: ");
double z = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите четвертое число: ");
double a1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите пятое число: ");
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите шестое число: ");
double z1 = double.Parse(Console.ReadLine()!);


double ab = Math.Sqrt(Math.Pow(a-a1, 2) + Math.Pow(b - b1, 2)+Math.Pow(z-z1, 2));

Console.WriteLine(ab);
