Console.Write("Введите номер дня недели: ");
int day = int.Parse(Console.ReadLine()!);

int a = 1;
int b = 2;
int c = 3;
int d = 4;
int e = 5;
int f = 6;
int g = 7;

if(day == a)
{
    Console.WriteLine ("понедельник");
    Console.WriteLine ("Будни");
}

if(day == b)
{
    Console.WriteLine ("вторник");
    Console.WriteLine ("Будни");
}
if(day == c)
{
    Console.WriteLine ("среда");
    Console.WriteLine ("Будни");
}
if(day == d)
{
    Console.WriteLine ("четверг");
    Console.WriteLine ("Будни");
}
if(day == e)
{
    Console.WriteLine ("пятница");
    Console.WriteLine ("Будни");
}
if(day == f)
{
    Console.WriteLine ("суббота");
    Console.WriteLine ("выходной!");
}
if(day == g)
{
    Console.WriteLine ("воскресение");
    Console.WriteLine ("выходной!");
    }
