// Задача 27:
//  Напишите программу, которая принимает на вход число и выдаёт сумму 
//  цифр в числе.
//  452 -> 11
//  82 -> 10
//  9012 -> 12
 

 int number = ReadLine("Введите число: ");
 int lenght = NumberLenght(number);
 SumNumbers(number, lenght);


 // Функция ввода
 int ReadLine(string message)
 {
     Console.WriteLine(message);
     return Convert.ToInt32(Console.ReadLine());
 }

 // Функция подсчета цифр в числе
 int NumberLenght(int a)
 {
     int index = 0;
     while (a > 0)
     {
         a = a / 10;
         index++;
     }
     return index;
 }

 // Функция вывода суммы цифр в числе
 void SumNumbers(int n, int len)
 {
     int sum = 0;
     for (int i = 1; i <= len; i++)
     {
         sum += n % 10;
         n /= 10;
     }
     Console.WriteLine(sum);
 }