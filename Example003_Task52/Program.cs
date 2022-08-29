/*Задача 52. 
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце. */


int n = 12;
int min = -9;
int max = 9;

int[] CreateArray(int n, int min, int max)
{
    int[] array1 = new int[n];
    for (int i = 0; i < n; i++)
    {
        array1[i] = new Random().Next(min, max +1);
    }
    return array1;
}

void PrintArray(int[] array2)
{
    for (int i = 0; i < array2.Length; i++)
    {
        Console.Write($"{array2[i]} ");
    }
    Console.WriteLine();
}
PrintArray(CreateArray(n, min, max));

int[] Summ(int[] array1)
{
    int[] sum = new int[2];
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i] < 0) sum[0] += array1[i];
        
        else sum[1] += array1[i];
    }
    return sum;
}

PrintArray(Summ(CreateArray(n, min, max)));
