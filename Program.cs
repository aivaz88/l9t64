// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Clear();

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
PrintAllNumbers(N);


void PrintAllNumbers(int N)
{
    if (N == 1) Console.Write($"{N}.");
    else 
    {
        Console.Write($"{N}, ");
        PrintAllNumbers(--N);
    }
}
