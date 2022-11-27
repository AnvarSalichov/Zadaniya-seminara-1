// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Hello, Camrad!");
Console.WriteLine("Введите целое число больше нуля");
int N=Convert.ToInt32(Console.ReadLine());
if (N<1)
    Console.WriteLine("Вы ввели неверное число");
else
    Console.WriteLine("Четные числа от 1 до "+N+ ":");
    for (int i = 1; i <= N; i++)
    if (i%2==0)
    Console.WriteLine(i);
