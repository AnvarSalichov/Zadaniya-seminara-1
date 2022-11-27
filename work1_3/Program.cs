// Задача 6: Напишите программу, которая на вход принимает число 
// и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Hello, Camrad!");
Console.WriteLine("Введите целое число на проверку");
int num=Convert.ToInt32(Console.ReadLine());

if (num%2)
    Console.WriteLine("Число "+num+ " является четным");
else 
    Console.WriteLine("Число "+num+ " нечетное");
