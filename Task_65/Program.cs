﻿// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

internal partial class Program
{
    private static void Main(string[] args)
    {
        
        int start = 4;
        int end = 10;
        Console.WriteLine($"M = {start}; N = {end} -> {recursive(start, end)}");
    }

    static string recursive(int start, int end)
    {
        if(start > end) return String.Empty;
        if (start == end + 1) return String.Empty;
        return $"{start} " + recursive(start + 1, end);
    }
}