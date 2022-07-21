// 12. Удалить вторую цифру трёхзначного числа

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число: {number}");
int x = (number / 10) % 10;
Console.WriteLine($"Вторая цифра введеного числа : {x}");

