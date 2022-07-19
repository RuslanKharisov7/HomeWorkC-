// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите целое положительное число");
double N = double.Parse(Console.ReadLine()!);
double M = 1;
while(M<=N)
{
    Console.WriteLine(Math.Pow(M,3));
       M++;
}