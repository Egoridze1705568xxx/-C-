//Задача 60. ...Сформируйте трёхмерный массив из  двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2

/*

Console.Write("Введите колличество строк: ");
double m = double.Parse(Console.ReadLine());
Console.Write("Введите колличество столбцов: ");
double n = double.Parse(Console.ReadLine());
Console.Write("Введите колличество столбцов: ");
double x = double.Parse(Console.ReadLine());


double[, ,] array =  GenereteRandom2DArray(m, n, x);

PrintArray(array);

void PrintArray(double[, ,] array )
{
for (var i = 0; i < array.GetLength(0); i++)
{
    for (var j = 0; j < array.GetLength(1); j++)
    {
       for (int z = 0; z < array.GetLength(2); z++)
       {
        
       }
       // Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}
}

double[, ,] GenereteRandom2DArray(double m, double n, double x)
{
    double [, ,] array = new double [(int)m, (int)n, (int)x];

    Random random = new Random();

    for (var i = 0; i < m; i++)
    {
        for (var j = 0; j < n; j++)
        {
                for (int z = 0; z < x; z++)
                {
                    array [i,j,z] = random.Next(0,100);
                    Console.Write($"{array[i,j,z]} ");
                    Console.Write($"({i},{j},{z}) ");

                }
        
        }
        Console.WriteLine();
    }
    return array;
}

*/
