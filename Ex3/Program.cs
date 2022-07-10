//2. Даны два числа. Показать большее и меньшее число
//Z
double numberA = new Random().Next();
double numberB = new Random().Next();
Console.WriteLine("Первое число");
Console.WriteLine(numberA);
Console.WriteLine("Второе число");
Console.WriteLine(numberB);

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