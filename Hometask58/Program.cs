// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


Console.WriteLine("Произведение двух матриц");
int[,] arrayA = CreateMatrix(2, 2, 1, 5);    
int[,] arrayB = CreateMatrix(2, 2, 1, 5);    
PrintMatrix(arrayA); 
PrintMatrix(arrayB);     
int[,] newMatrix = NewMatrix(arrayA, arrayB);
Console.WriteLine("     = ");
PrintMatrix(newMatrix);
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

int[,] NewMatrix(int[,]matrixA,int[,]matrixB)
{
    int[,] res = new int[matrixA.GetLength(0),matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            for (int k = 0; k < matrixB.GetLength(0); k++)
            {
                res[i,j] = res[i,j]+matrixA[i,k]*matrixB[k,j];                
            }            
        }
    }
    return res;
}


