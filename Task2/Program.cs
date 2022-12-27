/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15-> 120
M = 4; N = 8. -> 30
*/

int SumOf(int m, int n)
{
    int sum = 0;
    if (m == n) return m;
    else return sum + n + SumOf(m, n - 1);
}
Console.WriteLine(SumOf(1, 15));