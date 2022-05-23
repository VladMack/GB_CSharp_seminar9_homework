using System;
using static System.Console;

Clear();
WriteLine("Введи начальное и конечное значения через пробел:");
int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
int m = numbers[0];
int n = numbers[1];
WriteLine(sumNumToNum(m, n));

int sumNumToNum(int start, int end)
{
    if (start == end) return end;
    return (start + sumNumToNum(start + 1, end));
}