// 9.Показать последнюю цифру трёхзначного числа
Console.WriteLine("Введите трех значное число");
int number = int.Parse(Console.ReadLine()!);
int x = number % 10;
Console.WriteLine($"Полследняя цифра введеного числа: {x}");
