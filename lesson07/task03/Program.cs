// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

using System;

class Program
{
    static void PrintArrayReverse(int[] arr, int index)
    {
        if (index == arr.Length)
        {
            return;
        }

        PrintArrayReverse(arr, index + 1);
        Console.Write(arr[index] + " ");
    }

    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 7, 5 };

        Console.WriteLine("Элементы массива, начиная с конца:");
        PrintArrayReverse(array, 0);
    }
}