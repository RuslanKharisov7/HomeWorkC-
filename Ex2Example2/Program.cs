
Console.WriteLine("Введите первое число");
double numberA = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
double numberB = double.Parse(Console.ReadLine()!);

if(numberA / numberB == numberB)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго");
}
