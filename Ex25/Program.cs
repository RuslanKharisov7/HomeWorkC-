//Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("ВВедите число A");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine("A в степени B равно:" +  Math.Pow(A, B));


