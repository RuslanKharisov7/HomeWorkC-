// 4. Найти максимальное из трех чисел
//Я вижу решение данной задачи следующим образом: Имеем 3 натуральных числа, нужно найти наибольшее из них

Console.WriteLine("Введите первое число");
double a = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
double b = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число");
double  c = double.Parse(Console.ReadLine()!);
double max = a;

if (b > max) max = b;
if (c > max) max = c;
Console.WriteLine("Максимальное число равно: " +max);