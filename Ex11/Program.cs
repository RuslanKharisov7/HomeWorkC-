// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int number = new Random().Next(10, 100);
Console.WriteLine(number);
int x = number/10;
int y = number % 10;
if (x>y)
{
    Console.WriteLine($"Наибольшее число :  {x}");
}
else 
{
    Console.WriteLine($"Наибольшее число : {y}");
}

