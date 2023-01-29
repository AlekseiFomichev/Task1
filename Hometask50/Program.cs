// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 5},");
            else Console.Write($"{matrix[i, j], 5}  ");
        }
        Console.WriteLine("]");
    }
}
int UserEnter(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int row = UserEnter("Введите значение строки");
int column = UserEnter("Введите значение столбца");

{

    int[,] matr = CreateMatr(row, column);
    PrintMatrix(matr);
    Console.WriteLine();
    int rowNumber = UserEnter("Введите номер желаемой строки");
    int colNumber = UserEnter("Введите номер желаемого столбца");
    if (row > rowNumber && column > colNumber || 
    row < rowNumber && column > colNumber || 
    row > rowNumber && column < colNumber)
    {
        Console.Write($"Значение выбранного элемента матрицы {rowNumber,colNumber}");
    }
    else Console.Write("Такого элемента не существует");
}