﻿// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе 
// показывает последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8
// - % - получить при делении на 10 последнее число, на 100 последние 2 числа (остаток выводит после деления) // - выводит основное число

Console.WriteLine("start");

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Последняя цифра: "+ (a % 10));

Console.WriteLine("end");