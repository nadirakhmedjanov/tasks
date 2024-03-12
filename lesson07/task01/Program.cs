// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке 
// от M до N. Использовать рекурсию, не использовать циклы.

string NaturalList(int n, int m)
{
    if (n == m)
    { return Convert.ToString(m); }
    if (n > 0)
    { return n + " " + NaturalList(n + 1, m); }
    else
    {
        return NaturalList(n + 1, m);
    }
}

Console.WriteLine("Введите нижнюю границу промежутка:");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите верхнюю границу промежутка:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(NaturalList(n, m));
