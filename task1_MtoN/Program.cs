using System;
using static System.Console;

Clear();
WriteLine("Введи большее и меньшее числа через пробел:");
int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
int m = numbers[0];
int n = numbers[1];
WriteLine(GetNumbers(m, n));

string GetNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return (start.ToString() + " " + GetNumbers(start - 1, end));
}