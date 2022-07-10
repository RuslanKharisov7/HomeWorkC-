//2. Даны два числа. Показать большее и меньшее число

Console.WriteLine("Введите первое число");
double numberA = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
double numberB = double.Parse(Console.ReadLine()!);

if (numberA>numberB)
{
    Console.WriteLine("Максимально число");
    Console.WriteLine(numberA);
    Console.WriteLine("Минимальное число");
    Console.WriteLine(numberB);
}
else
{
    Console.WriteLine("Максимально число");
    Console.WriteLine(numberB);
    Console.WriteLine("Минимальное число");
    Console.WriteLine(numberA);
}