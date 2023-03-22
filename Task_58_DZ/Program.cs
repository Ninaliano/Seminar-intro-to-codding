// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];   // 0, 1
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)   //rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++)  // columns
            matrix[i, j] = rnd.Next(min, max + 1);
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j]}, ");
            else Console.Write($"{matrix[i, j]}");
        }
        Console.WriteLine();
    }
}

int[,] MatrixMultiply(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    if (matrix1.GetLength(0) == matrix2.GetLength(1))
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                for (int n = 0; n < matrix1.GetLength(1); n++)
                {
                    result[i, j] += matrix1[i, n] * matrix2[n, j];
                }
            }
        }
    return result;
}


var arr1 = CreateMatrixRndInt(2, 2, 0, 10);
PrintMatrix(arr1);
var arr2 = CreateMatrixRndInt(2, 2, 10, 20);
PrintMatrix(arr2);
PrintMatrix(MatrixMultiply(arr1, arr2));
