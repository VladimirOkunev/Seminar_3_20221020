// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();

Console.Write("Enter three digits number: ");

int number = int.Parse(Console.ReadLine() ?? "0");


while (number < 100 || number > 999) // check the correctness of the value
{
    Console.Clear();
    Console.WriteLine("Incorrect value");
    Console.Write("Please, enter again three digits number:  ");
    number = int.Parse(Console.ReadLine() ?? "0");
}

number = number/10;
int secondDigit = number%10;
Console.Write($"The third digit of the number:  {secondDigit}");

