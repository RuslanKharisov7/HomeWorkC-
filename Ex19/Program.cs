// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число от 10000 до 99999");
int number = int.Parse(Console.ReadLine()!);
int a = number / 10000;
int b = (number / 1000)%10;
int c = (number / 100) %10;
int d = (number /10) %10;
int e = number % 10;

if (a+b == d+e)
{
    Console.WriteLine("Введенное число является палиндромом");
}
if (number>99999 || number<10000)
{
    Console.WriteLine("Введеное число не принадлежит диапозону от 10000 до 99999");
}
else
{ if (a+b != d+e)
{
    Console.WriteLine("Введенное число не является палиндромом");
}
}