// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int SumDigits(int number)
{
int size = number.ToString().Length;
int sum = 0;
for (int i = 0; i < size; i++)
{
sum += number%10;
number/=10;
}
return sum;
}

int number = Prompt("Введите число: ");
int result = SumDigits(number);
Console.WriteLine("Сумма цифр числа: " + result);