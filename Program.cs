//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


Console.Write("Введите колличество строк: ");
double m = double.Parse(Console.ReadLine());
Console.Write("Введите колличество столбцов: ");
double n = double.Parse(Console.ReadLine());



double[,] array =  GenereteRandom2DArray(3, 4);

PrintArray(array);

void PrintArray(double[,] array )
{
for (var i = 0; i < array.GetLength(0); i++)
{
    for (var j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}
}

double[,] GenereteRandom2DArray(double m, double n)
{
    double [,] array = new double [(int)m, (int)n];

    Random random = new Random();

    for (var i = 0; i < m; i++)
    {
        for (var j = 0; j < n; j++)
        {
            array [i,j] = random.Next(-10,10);
            //Console.Write($"({i},{j})");
        }
        //Console.WriteLine();
    }
    return array;
}
