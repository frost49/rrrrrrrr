﻿int[] array = new int[10];
int count = 0;
Console.Write("[");

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100,1000);
    if (i == array.Length - 1)
    {
        Console.Write(array[i] + "]");
    }
    else 
    {
        Console.Write(array[i] + ", ");
    }
}
Console.WriteLine();

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine("Количество чётных чисел в массиве: " + count);
