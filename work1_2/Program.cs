﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Hello, Camrad!");
Console.WriteLine("Введите первое число");
int num1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int num3=Convert.ToInt32(Console.ReadLine());
int maxnum = num1;
if (num2 > maxnum)
{
    maxnum = num2;
}   
if (num3 > maxnum)
{
    maxnum = num3;   
}
Console.WriteLine("Число "+ maxnum+ " является наибольшим из них");

