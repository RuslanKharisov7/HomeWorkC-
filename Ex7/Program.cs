// 7. Показать числа от -N до N

Console.WriteLine("Введите число N");
double N = double.Parse(Console.ReadLine()!);
double M = -N;

while (M<N)
{
  Console.WriteLine(M);
  M = M + 1;
}
