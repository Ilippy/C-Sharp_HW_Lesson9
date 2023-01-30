// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using NumberMain;
internal partial class Program
{
    private static void Main(string[] args)
    {
        long m = Numbers.EnterLongNumber("Введите значение m");
        long n = Numbers.EnterLongNumber("Введите значение n");
        Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {AkkermanFunction(m, n)}");
    }

    static long AkkermanFunction(long m, long n)
    {
        if (m == 0)
            return n + 1;
        else
          if ((m != 0) && (n == 0))
            return AkkermanFunction(m - 1, 1);
        else
            return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
    }


}