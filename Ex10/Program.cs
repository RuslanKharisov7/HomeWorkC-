﻿//10. Показать вторую цифру трёхзначного числа
// Я понимаю данную задачу следующим образом: Пользователь вводит, целое трехзначное число,  
// а программа выдает вторую цифру заданого числа

Console.WriteLine("Введите целое трехзначное число");
int number = int.Parse(Console.ReadLine()!);
int x = number / 100;
int y = (number / 10) % 10;
int z = number % 10;

Console.WriteLine($"Вторая цифра введеного числа :  {y}");




