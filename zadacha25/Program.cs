Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine()!);
int c = a;
int i = 1;
while (i < b)
{
    c = c * a;
    i++;
}
Console.Write("A в степени B равно: " + c);
