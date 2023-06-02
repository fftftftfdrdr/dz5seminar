// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 999);
}

void PrintArray(int[] array)
{
    foreach (var item in array)
        Console.Write($"{item} ");
    System.Console.WriteLine();
}

void sumchetnih(int[] array)
{
      int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        
        if (array[i] % 2 == 0)
        count++;
    }
    System.Console.WriteLine(count);
}
int [] array = new int [12];
FillArray(array);
PrintArray(array);
sumchetnih(array);
