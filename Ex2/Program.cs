//1. По двум заданным числам проверять является ли первое квадратом второго
// Я вижу решение данной задачи следующим образом: Заданы два числа и программа должна проверить является ли первое число
// квадратом второго

double numberA = new Random().Next();
double numberB = new Random().Next();
Console.WriteLine(numberA);
Console.WriteLine(numberB);
if (numberA/numberB == numberB)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго");
}


