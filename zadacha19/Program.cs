Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine()!;
int b = number.Length;

if (b == 5 )

if ( number[0] == number[4] && number[1] == number[3])
Console.WriteLine($"{number} - Палиндром");

else
Console.Write("не палиндром.");

else 
Console.Write("не пятизначное число");
