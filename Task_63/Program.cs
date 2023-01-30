// адача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"


internal class Program
{
    private static void Main(string[] args)
    {
        int number = 4;
        Console.WriteLine($"N = {number} -> {recursive(number)}");
    }

// recursive(4-1) + "4" = recurse(3-1) + "3 4 " = recurse(2-1) + "2 3 4 " = recurse(1-1) + "1 2 3 4 " = "1 2 3 4 "
    static string recursive(int number){
        if(number == 0) return String.Empty;
        return recursive(number-1) + $"{number} ";
    }
}