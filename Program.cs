/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
 a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
/*
Console.WriteLine("Введите 2 числа, что бы определить наименьшее и наибольшее ");
int a = int.Parse(Console.ReadLine( ));
int b = int.Parse(Console.ReadLine( ));
if (a > b){
    Console.Write ($"Набильшее число {a}, а наименьшее число {b}");
}
else {
    Console.Write ($"Набильшее число {b}, а наименьшее число {a}");
}

*/

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.WriteLine("Введите 3 числа, что бы определить наименьшее и наибольшее ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
if (a > b && a > c)
{
    Console.WriteLine($"Набильшее число {a}");
}
if (b > a && b > c)
{
    Console.WriteLine($"Набильшее число {b}");
}
if (c > b && c > a)
{
    Console.WriteLine($"Набильшее число {c}");
}
*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

/*
Console.WriteLine("Введите  число:  ");
int a = int.Parse(Console.ReadLine());
if (a % 2 == 0)
{
    Console.WriteLine("Число является четным и делится на 2 без остатка ");
}
else
{
    Console.WriteLine("Число не является четным и не делится на 2 без остатка ");
}
*/

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите  число:  ");
int namder_N = int.Parse(Console.ReadLine());
int number_start = 1;

while (number_start <= namder_N)
{
    if (number_start % 2 == 0)
    Console.Write(number_start);
    Console.Write(' ');
    number_start += 1;

}







