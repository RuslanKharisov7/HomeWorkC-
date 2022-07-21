// 12. Удалить вторую цифру трёхзначного числа

Console.WriteLine("Введите трехзначное число от 100 до 999");
int num = int.Parse(Console.ReadLine()!);
int x = (num / 10) % 10;
if (num > 999 || num < 100)
{
    Console.WriteLine("Введенное число не входит в указанный диапозон");
}
else 
{
    Console.WriteLine($"Вторая цифра введеного числа : {x}");
}