// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая 
// покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

void FillArray(int[] newArray)
{
int length = newArray.Length;
int index = 0;
while (index < length)
{
    newArray[index] = new Random().Next(100, 1000);
    index++;
}
}

void PrintArray(int[] array)
{
    int count = array.Length;
    int position = 0;
    while (position < count)
    {
    Console.WriteLine(array[position]);
    position++; 
    }
}

int CountEvenNumbers(int[] array)
{
int Count = 0;
  for (int i = 0 ; i < array.Length; i++)
  {
    if(array[i] % 2 == 0)
    {
      Count++;
    }
  }
  return Count;
}

int[] array = new int [5];
FillArray(array);
PrintArray(array);
Console.WriteLine($"Количество четных чисел в заданом массиве равняется: {CountEvenNumbers(array)}");
