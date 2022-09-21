// // Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// // 6 -> да
// // 7 -> да
// // 1 -> нет


// Console.WriteLine("Введите номер дня недели: ");
// string numberStr = Console.ReadLine();

// if (numberStr =="1") {
//     Console.WriteLine("-> нет");
// }
// else if (numberStr =="2") {
//     Console.WriteLine("-> нет");
// }
// else if (numberStr =="3") {
//     Console.WriteLine("-> нет");
// }
// else if (numberStr =="4") {
//     Console.WriteLine("-> нет");
// }
// else if (numberStr =="5") {
//     Console.WriteLine("-> нет");
// }
// else if (numberStr =="6") {
//     Console.WriteLine("-> да");
// }
// else if (numberStr =="7") {
//     Console.WriteLine("-> да");
// }
// else
// {
//     Console.WriteLine("Такого дня недели не существует! ");
// }


int number = int.Parse(numberStr);
if(number >=1 && number <= 5)
Console.WriteLine("нет");
else if(number == 6 || number == 7)
Console.WriteLine("да");
else
Console.WriteLine("Такого дня недели не существует! ");