// // 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

Console.WriteLine("Введите двух значное число от 10 до 99");
int number = int.Parse(Console.ReadLine()!);
int x = number / 10;
int y = number % 10;
if (x>y)
{
    Console.WriteLine($"Наибольшая цифра введеного числа : {x}");
    Console.WriteLine($"Наименьшая цифра введеного числа : {y}");
}
else
{
    Console.WriteLine($"Наибольшая цифра введеного числа : {y}");
    Console.WriteLine($"Наименьшая цифра введеного числа : {x}");
}

