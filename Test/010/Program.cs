// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

int FindeNewDigit(int num)
{
    int result = num % 100 / 10;
    return result;
}
int res = FindeNewDigit(number);
Console.WriteLine(res);