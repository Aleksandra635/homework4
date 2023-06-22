//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int number1 = Prompt("Введите 1 число: ");
int number2 = Prompt("Введите 2 число: ");

int GetSum(int number1, int number2)
{
int sum = 1;
for (int i = 1; i <= number2; i++)
{
    sum *= number1;
}
return sum;
}
int result = GetSum(number1, number2);
Console.WriteLine(result);