int[,] FillNewArr (int[,] NewArr)

{
for (int i = 0; i < NewArr.GetLength(0); i++)
{
    for (int j = 0; j < NewArr.GetLength(1); j++)
    {
        NewArr[i, j] = new Random().Next(1, 10);
    }
}
return NewArr;
}
void PrintNewArr (int[,] NewArr)
{
for (int i = 0; i < NewArr.GetLength(0); i++)
 {
     for (int j = 0; j < NewArr.GetLength(1); j++)
     {
       Console.Write(NewArr[i, j] + " ");
     }
     Console.WriteLine();
 }
}

int[,] NewArr = new int[3,4];
NewArr = FillNewArr(NewArr);
PrintNewArr(NewArr);

Console.Write("\n Введите число: ");
int number = int.Parse(Console.ReadLine()!);

Console.Write("\n"); 
bool numberInArr = false; 

for (int i = 0; i < NewArr.GetLength(0); i++)
{
    for (int j = 0; j < NewArr.GetLength(1); j++)
    {
         if (NewArr[i,j] == number) 
        { 
            numberInArr = true;
            Console.WriteLine($"[{Convert.ToInt32(i)},{Convert.ToInt32(j)}]"); 
        } 
    } 
} 
if (numberInArr) 
    {}
else 
    { 
        Console.Write($"нет такого числа"); 
    }