// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

using System;

class Program
{
    static int Ackermannfunction(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return Ackermannfunction(m - 1, 1);
        }
        else
        {
            return Ackermannfunction(m - 1, Ackermannfunction(m, n - 1));
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Введите значение m:");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите значение n:");
        int n = Convert.ToInt32(Console.ReadLine());

        int result = Ackermannfunction(m, n);
        Console.WriteLine($"{result}.");
    }
}