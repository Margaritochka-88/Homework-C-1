Console.WriteLine("Введите первое число");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = int.Parse(Console.ReadLine());



if (numberA > numberB) 
{
    Console.WriteLine($" max = {numberA}");
    Console.WriteLine($" min = {numberB}");
}
else if (numberA < numberB) 
{
    Console.WriteLine($" max = {numberB}");
    Console.WriteLine($" min = {numberA}");
}
else {
    Console.WriteLine("Числа равны ");
    
}
