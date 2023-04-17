using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите первое число: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int num2 = int.Parse(Console.ReadLine());

        int max = (num1 > num2) ? num1 : num2;

        Console.WriteLine("Наибольшее число: " + max);
    }
}
