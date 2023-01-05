double[,] array = new double[3, 4];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double number = new Random().Next(-10,10) + new Random().NextDouble();
        number = Math.Round (number, 1);
        array [i,j] = number;
         Console.Write(array[i,j] + ", ");
    }
    Console.WriteLine();
}
