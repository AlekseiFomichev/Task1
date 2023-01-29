// Задайте двумерный массив. Напишите программу, которая поменяет местами
// первую и последнюю строку массива.

int UserEnter(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void FillMatrix(int[,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ChangeMatrix(int[,] matrix)
{
    int size = matrix.GetLength(1) / 2;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < size; j++)
        {
            int firstNumber = matrix[i, j];
            int lastNumber = matrix[i, matrix.GetLength(1) - 1 - j];
            int change = matrix[i, j];
            matrix[i, j] = lastNumber;
            matrix[i, matrix.GetLength(1) - 1 - j] = change;
        }
    }
}

int rowSize = UserEnter("Write a row size: ");
int columnSize = UserEnter("Write  a column size: ");
int[,] matrix = new int[rowSize, columnSize];

FillMatrix(matrix);
PrintMatrix(matrix);
System.Console.WriteLine();

ChangeMatrix(matrix);
PrintMatrix(matrix);