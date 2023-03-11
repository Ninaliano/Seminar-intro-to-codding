// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

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


int[,] CreateNewMatrix(int [ , ] matrix)
{
    int[,] newMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];   // 1,0
     for (int j = 0; j < matrix.GetLength(1); j++)   
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        newMatrix [j,i]=matrix[i,j];
        
            }     
    return newMatrix;

}


int[,] array2d = CreateMatrixRndInt(4, 5, -10, 10);
PrintMatrix(array2d);
Console.WriteLine();
int [,] newMatrixx = CreateNewMatrix(array2d);
PrintMatrix(newMatrixx);