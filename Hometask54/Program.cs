// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateMatrix(int row, int col, int min, int max) 
{ 
    int[,] matrix = new int[row, col]; 
    Random rnd = new Random(); 
    for (int i = 0; i < matrix.GetLength(0); i++) 
    { 
        for (int j = 0; j < matrix.GetLength(1); j++) 
        { 
            matrix[i, j] = rnd.Next(min, max); 
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
            Console.Write($"{matrix[i, j],3}"); 
            if (j < matrix.GetLength(1) - 1) Console.Write(", "); 
        } 
        Console.WriteLine("  ]"); 
    } 
    Console.WriteLine(); 
} 
void PrintArray(int[] arr) 
{ 
    Console.Write("["); 
    for (int i = 0; i < arr.Length; i++) 
    { 
        Console.Write(arr[i]); 
        if (i < arr.Length - 1) Console.Write(", "); 
    } 
    Console.Write("]"); 
} 
 
void OrderMatrix(int[,] matrix) 
{ 
    for (int i = 0; i < matrix.GetLength(0); i++) 
    { 
        for (int l = 0; l < matrix.GetLength(1); l++) 
        { 
            for (int j = 0; j < matrix.GetLength(1); j++) 
            { 
                for (int k = 1; k < matrix.GetLength(1); k++) 
                { 
                    if (matrix[i, k - 1] < matrix[i, k]) 
                    { 
                        int temp = matrix[i, k - 1]; 
                        matrix[i, k - 1] = matrix[i, k]; 
                        matrix[i, k] = temp; 
                    } 
                } 
            } 
        } 
    } 
} 
 
int[,] matrix = CreateMatrix(4, 8, 1, 9); 
PrintMatrix(matrix); 
OrderMatrix(matrix); 
PrintMatrix(matrix);