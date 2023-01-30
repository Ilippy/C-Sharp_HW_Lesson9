// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using NumberMain;
internal partial class Program
{
    private static void Main(string[] args)
    {
        int m = Numbers.EnterNumber("Введите целое натуральное число M", 1, int.MaxValue);
        int n = Numbers.EnterNumber("Введите целое натуральное число N", 1, int.MaxValue);
        Console.WriteLine($"M = {m}, N = {n} -> {SumNumbers(m, n)}");
    }

    static int SumNumbers(int start, int end)
    {
        if (start > end)
        {
            int temp = start;
            start = end;
            end = temp;
        }
        if (start == end) return end;
        return start + SumNumbers(start + 1, end);
    }
}