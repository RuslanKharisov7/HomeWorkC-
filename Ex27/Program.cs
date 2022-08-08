//Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число от 0 до 1000000");
int number = int.Parse(Console.ReadLine()!);

if (number < 0 || number > 1000000)
{
    Console.WriteLine("Введенное число не соответствует указаному диапазону");
}
else
{
SumMetod(number);

static void SumMetod(int number)
{
    int a = number / 1000000;
    int b = (number / 100000) % 10;
    int c = (number / 10000) % 10;
    int d = (number / 1000) % 10;
    int e = (number / 100) % 10;
    int f = (number / 10) % 10;
    int g = number % 10;
    int sum = a + b + c + d + e + f + g;
    Console.WriteLine($"Сумма цифр введеного числа равна {sum}");
}
}