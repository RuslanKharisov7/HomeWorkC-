// Напишите метод(ы), которай задаёт массив из 8 элементов и выводит их на экран.

void FillArrray(int[] newArray)
{
    int length = newArray.Length;
    int index = 0;
    while (index < length)
    {
        newArray[index] = new Random().Next();
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
int[] array = new int[8];
FillArrray(array);
PrintArray(array);
Console.WriteLine();
