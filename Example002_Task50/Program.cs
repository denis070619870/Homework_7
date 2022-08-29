/*Задача 50. 
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.*/


Console.WriteLine("Введите номер строки нужного элемнта: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер столбца нужного элемента: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int [,] matrix = new int [10,10];
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

if (n > matrix.GetLength(0) && m > matrix.GetLength(1))
{
    Console.WriteLine($"Вы вышли за рамки массива. Значение элемента {n} строки, {m} столбца отсутствует.");
    Console.WriteLine();
}
else
{
    Console.WriteLine($"Значение элемента: {n} строки, {m} столбца = {matrix[n-1,m-1]}");
    Console.WriteLine();
}

PrintArray(matrix);