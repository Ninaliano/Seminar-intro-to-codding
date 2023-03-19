// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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


void ArithmeticMean(int[,] matrixx)
{
    double arithmeticMean;
    for (int j = 0; j < matrixx.GetLength(1); j++)
    {
        arithmeticMean = 0;
        for (int i = 0; i < matrixx.GetLength(0); i++)
        {
            arithmeticMean = matrixx[i, j] + arithmeticMean;
        }
        arithmeticMean = arithmeticMean / matrixx.GetLength(0);
        Console.Write($"{Math.Round(arithmeticMean, 1)}; ");
    }

}


int[,] array2d = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(array2d);
Console.Write($"Среднее арифметическое каждого столбца:   ");
ArithmeticMean(array2d);
