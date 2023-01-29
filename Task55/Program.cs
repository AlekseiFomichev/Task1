// Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если
// это невозможно, программа должна вывести сообщение для 
// пользователя.

// int[,] CreatMatrixRndIntArray(int rowSize, int colSize, int minValue, int maxValue)//Метод генерации массива со случайными элементами
// {
//     int[,] resArray = new int[rowSize, colSize];
//     Random rnd = new Random();
//     for (int i = 0; i < resArray.GetLength(0); i++)
//         for (int j = 0; j < resArray.GetLength(1); j++)
//             resArray[i, j] = rnd.Next(minValue, maxValue + 1);
//     return resArray;
// }
// string ArrayToString(int[,] array)//Метод преобразования массива в строку
// {
//     string result = "";
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         result += "[";
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             result = result + $" {array[i, j],3}";
//             result = j < (array.GetLength(1) - 1) ? result + "," : result;//для корректности вывода запятых    
//         }
//         result += "]\n";
//     }
//     return result;
// }
// void ExcangeElemRowToCol(int[,] matrix)
// {
//     int tmp;
//     for (int i = 1; i < matrix.GetLength(0); i++)
//     {
//         for (int j = i; j < matrix.GetLength(1); j++)
//         {
//             tmp = matrix[i, j];
//             matrix[i, j] = matrix[j, i];
//             matrix[j, i] = tmp;
//         }
//     }
// }
// //Параметры для генерации двумерного массива типа int.
// int matrixRowSize = 3,
//     matrixColSize = 3,
//     matrixMinValue = -99,
//     matrixMaxValue = 99;
// int[,] rndMatrixInt = CreatMatrixRndIntArray(matrixRowSize, matrixColSize, matrixMinValue, matrixMaxValue);

// Console.WriteLine(ArrayToString(rndMatrixInt));
// ExcangeElemRowToCol(rndMatrixInt);
// Console.WriteLine(ArrayToString(rndMatrixInt));

// if (rndMatrixInt.GetLength(0)==rndMatrixInt.GetLength(1))
// {
//     ExcangeElemRowToCol(rndMatrixInt);
//     Console.WriteLine(ArrayToString(rndMatrixInt));
// }
// else
// {
//     Console.WriteLine("Нельзя преобразовать не квадратную матрицу.");
// }

//метод создания двумерного массива из псевдочисел
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
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

//метод вывода двумерного массива в консоль
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5},");
            else Console.Write($"{matrix[i, j],5}  ");
        }
        Console.WriteLine("]");
    }
}

void ReplaceRowsColumns(int[,] matr)
{
    int temp = 0;
    for (int i = 1; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            temp = matr[i, j];
            matr[i, j] = matr[j, i];
            matr[j, i] = temp;
        }
    }
}

int[,] array2D = CreateMatrixRndInt(4, 4, -10, 10);
PrintMatrix(array2D);
Console.WriteLine();

if (array2D.GetLength(0)==array2D.GetLength(1))
{
    ReplaceRowsColumns(array2D);
    PrintMatrix(array2D);
}
else Console.WriteLine("невозможно");