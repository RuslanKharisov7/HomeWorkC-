// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.Write($"Введи количество элементов массива: ");
int array = Convert.ToInt32(Console.ReadLine()); 

int RandomNumbers(int array, int min, int max)
  {
  int[] randomNumbers = new int[array];
  int SumOddNumbers = 0;
  Console.WriteLine("Массив соответствующий введенной размерности: ");

    for (int i = 0; i < randomNumbers.Length; i++ ){
      randomNumbers[i] = new Random().Next(min, max);

      Console.Write(randomNumbers[i] + " ");

      if (i % 2 != 1)
      {
        SumOddNumbers = SumOddNumbers + randomNumbers[i];
      }
    }
  return SumOddNumbers;
  }
int randomNumbers =  RandomNumbers(array, 1, 10);
Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях: {randomNumbers}");