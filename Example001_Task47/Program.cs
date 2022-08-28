// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


int m = Convert.ToInt32(3);
int n = Convert.ToInt32(4);

double[,] matrix = new double[m,n];

PrintArray(matrix);
FillArray(matrix);
PrintArray(matrix);

void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j] } \t");
        }
    Console.WriteLine();    
    }
}
void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = Convert.ToDouble(new Random().Next(-10, 10)) / 10; 
        }
    Console.WriteLine();    
    }
}

