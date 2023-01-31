// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

using NumberMain;
internal partial class Program
{
    private static void Main(string[] args)
    {
        int a = Numbers.EnterNumber("Введите целое число A");
        int b = Numbers.EnterNumber("Введите целое число B");

        Console.WriteLine($"A = {a}; B = {b} -> {Pow(a, b)}");
    }

    static double Pow(int a, int b)
    {
        System.Console.WriteLine($"{a} , {b}");
        if (b == 0) return 1;
        if (b < 0) return 1 / Pow(a, -b);
        if (b % 2 == 0) return Pow(a * a, b / 2);
        return a * Pow(a, b - 1);
    }

}