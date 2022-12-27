/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3->A(m, n) = 9
m = 3, n = 2->A(m, n) = 29*/

int A(int i, int j)
{
    if (i == 0) return j + 1;
    else if (j == 0) return A(i - 1, 1);
    else return A(i - 1, A(i, j - 1));
}

Console.WriteLine(A(2, 0));