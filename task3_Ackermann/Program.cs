using System;
using static System.Console;

Clear();
WriteLine("Введи m и n в A(m,n) через пробел:");
int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
int m = numbers[0];
int n = numbers[1];
WriteLine(Ack(m, n));

int Ack(int number1, int number2)
{
    if (number1 == 0) return number2 + 1;
    if (number1 != 0 && number2 == 0) return Ack(number1 - 1, 1);
    if (number1 > 0 && number2 > 0) return Ack(number1 - 1, Ack(number1, number2 - 1));
    return 0;
}