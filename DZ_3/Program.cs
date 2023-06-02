// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().NextDouble();
}

void PrintArray(double[] array)
{
    foreach (var item in array)
        Console.Write($"{item} ");
    System.Console.WriteLine();
}

void MinMax(double[] array)
{
    double max = 0;
    double min = 0;
    double res = 0;
    for (int i = 0; i < array.Length; i++)
   {
    if (array[i] > max )
    max = array[i];
    else if (array[i] < min)
    min = array[i];
   }
   res = max - min;
   System.Console.WriteLine(res);

}


double[] array = new double [8];
FillArray(array);
PrintArray(array);
MinMax(array);


