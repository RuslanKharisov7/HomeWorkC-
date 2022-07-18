// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным 

Console.WriteLine("Введите число от 1 до 7");
int n = int.Parse(Console.ReadLine()!);

if (n==6 || n==7)
{
 Console.WriteLine("Этот день является выходным");
}

if (n>7)
    {
        Console.WriteLine("В неделе только 7 дней");
    }

if (n<1)
{
    Console.WriteLine("В неделе не может быть меньше одного дня");
}

if (n==1 || n==2 || n==3 || n==4 || n==5)
{
    Console.WriteLine("Этот день является рабочим");
}