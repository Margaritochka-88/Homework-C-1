﻿Console.WriteLine("Введите первое число");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int numberC = int.Parse(Console.ReadLine());

int max= numberA;

if (numberB > numberA) max=numberB;
if (numberC > numberA) max=numberC;

Console.WriteLine(max);
