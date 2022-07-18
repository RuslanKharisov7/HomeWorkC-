//3.По заданному номеру дня недели вывести его название
// Я вижу решение данной задачи следующим образом: Имеется три случайных числа, программа должна найти наибольшее
Console.WriteLine("Введите число от 1 до 7");
int number = int.Parse(Console.ReadLine()!);
if (number == 1)
{
    Console.WriteLine(number);
    Console.WriteLine("Monday");
}
if (number == 2)
{
    Console.WriteLine(number);
    Console.WriteLine("Tuesday");
}
if (number == 3)
{
    Console.WriteLine(number);
    Console.WriteLine("Wensday");
}
if (number == 4)
{
    Console.WriteLine(number);
    Console.WriteLine("Thursday");
}
if (number == 5)
{
    Console.WriteLine(number);
    Console.WriteLine("Friday");
}
if (number == 6)
{
    Console.WriteLine(number);
    Console.WriteLine("Saturday");
}
if (number == 7)
{
    Console.WriteLine(number);
    Console.WriteLine("Sunday");
}
if (number > 7)
{
    Console.WriteLine("В неделе только 7 дней");
}
if (number < 1)
{
    Console.WriteLine("В неделе не может быть меньше одного дня");
}