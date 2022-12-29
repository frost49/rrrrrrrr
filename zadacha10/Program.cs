Console.Write("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine()!);

int b = a / 10 % 10; 
if (a > 99 && a <1000) 
{
string str = $"Второе = {b} ";
Console.Write(str);
}
else Console.Write("Это не трехзначное число");
