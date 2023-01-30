// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using NumberMain;
internal partial class Program
{
    private static void Main(string[] args)
    {
        int number = Numbers.EnterNumber("Введите целое число N");
        Console.WriteLine($"N = {number} -> \"{recursive(number)}\"");
    }

    static string recursive(int number){
        if(number == 1) return "1";
        return $"{number}, " + recursive(number-1);
    }
}