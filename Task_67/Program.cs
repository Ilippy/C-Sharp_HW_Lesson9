// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

using NumberMain;
internal partial class Program
{
    private static void Main(string[] args)
    {
        int number = Numbers.EnterNumber("Введите целое число");
        
        Console.WriteLine($"\n{number} -> {recursive(number)}");

    }


    // 1234 = 4 + recursive(123) = 4 + 3 + recursive(12) = 4 + 3 + 2 + recursive(1) = 4 + 3 + 2 + 1 + recursive(0) = 4 + 3 + 2 + 1 + 0;
    static int recursive(int number)
    {
        if (number == 0) return 0;
        // Console.Write(number /10 == 0 ? number%10 : $"{number%10} + ");
        return number % 10 + recursive(number / 10);
    }

}