// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

Console.Clear();

Console.Write("Enter a number: ");

int number = int.Parse(Console.ReadLine() ?? "0");

if(number < 100)
{ 
Console.Write("There is no the third digit: ");
}
else
{
while(number > 999)
{
    number = number / 10;
}
int thirdDigit = number % 10;
Console.Write($"The third digit of the number: {thirdDigit}");
}
