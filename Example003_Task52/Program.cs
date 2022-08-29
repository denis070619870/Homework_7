/*Задача 52. 
Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце. */

Console.WriteLine("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int [,] matrix = new int [m,n];
FillArray(matrix);

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
        {        
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                matr [i,j] = new Random().Next(1, 100);
            }   
        }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j] } \t");
        }   
        Console.WriteLine(""); 
    }
}

for (int j = 0; j < matrix.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        avarage = (avarage + matrix[i, j]);
    }
    avarage = avarage / n;
    
    Console.Write($"{avarage} \t");

}
Console.WriteLine();

PrintArray(matrix);