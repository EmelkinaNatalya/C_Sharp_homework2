﻿//  Задача 10: Напишите программу, которая принимает на вход 
//  трёхзначное число и на выходе показывает вторую цифру этого числа.   

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());

if (N>99 && N<1000) 
Console.Write(N = N/10%10); 
else 
Console.Write("Введенное число не является трехзначным, введите трехзначное число");

