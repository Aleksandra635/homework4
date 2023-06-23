// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}  

int[]GiveArray ()
{
int [] array = new int [8];
for (int i = 0; i < 8; i++)
{
Console.Write("Число{0}: ", i + 1);
array [i] = Prompt("");
}
return array;
}
int[] result = GiveArray();
Console.WriteLine($"Вы ввели следующие числа: [{string.Join(",", result)}]");

