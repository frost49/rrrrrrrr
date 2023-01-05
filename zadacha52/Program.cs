﻿void FillArray (int[, ]matr)
{
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0; j<matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);
        }
    }
}

void PrintArray (int[, ]matr)
{
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0; j<matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int [, ] matrix = new int [3, 3];

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

for (int i = 0; i < matrix.GetLength(1); i++)
{
    double average = 0;

    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        average = average + matrix [j,i];
    }
    double x = (float)average / matrix.GetLength(0);
    x = Math.Round(x, 1);
    Console.WriteLine();
    Console.WriteLine($" Среднее арифметическое элементов {i+1} столбца = {x}");
}
