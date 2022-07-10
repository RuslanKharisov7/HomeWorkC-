// 3. По заданному номеру дня недели вывести его название
// Я вижу решение данной задачи следующим образом: Имеется диапазон чисел от 1 до 7 и
// относительно того какое число вводится на экранее появляется название дня недели соответствующего этому числу

int number = new Random().Next(1,7);
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
