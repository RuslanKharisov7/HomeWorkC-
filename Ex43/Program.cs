// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Введите значение b1");
var b1 = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine("Введите значение k1");
var k1 = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine("Введите значение b2");
var b2 = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine("Введите значение k2");
var k2 = Convert.ToDouble(Console.ReadLine()!);

var x =  -(b1 - b2) / (k1 - k2);
var y = k1 * x + b1;

Console.WriteLine($"Прямые пересекутся в точке с координатами : {x};{y}");