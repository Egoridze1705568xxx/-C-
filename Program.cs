/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

/*
int n = int.Parse(Console.ReadLine( ));

PrintNumbers(n);

void PrintNumbers(int n)
{
    if (n < 1)
    {
        return;
    }

    Console.Write(n);
    Console.Write(", ");
    PrintNumbers(--n);
}

*/


/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

/*
int m = int.Parse(Console.ReadLine( ));
int n = int.Parse(Console.ReadLine( ));
int result = Range(m,n);

Console.WriteLine(result);

int Range (int m,int n)
{
    int sum = 0;
    for (var i = m; i <= n; i++)
    {
        sum += i;
    }
    return sum;
}

*/

/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
/*
int m = int.Parse(Console.ReadLine( ));
int n = int.Parse(Console.ReadLine( ));
int result = S(m,n);
Console.WriteLine(result);

int S(int m, int n)
{
  if (m == 0)
    return n + 1;
  else
    if ((m != 0) && (n == 0))
      return S(m - 1, 1);
    else
      return S(m - 1, S(m, n - 1));
}
*/
