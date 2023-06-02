// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 10);
}

void PrintArray(int[] array)
{
    foreach (var item in array)
        Console.Write($"{item} ");
    System.Console.WriteLine();
}

void SumNum(int[] array)
{
     int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
       if (i % 2 == 0)
       i++;
       count = count + array[i];
    
    }
    System.Console.WriteLine(count);
}
int [] array = new int [12];
FillArray(array);
PrintArray(array);
SumNum(array);