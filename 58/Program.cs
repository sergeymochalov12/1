// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

//Генерация массива
int[,] FillMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] tempMatrix = new int[row, col];
    var rand = new Random();
    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return tempMatrix;
}

//Печать двумерного массива
void PrintMatrix(int[,] matrixForPrint)
{
    for (int i = 0; i < matrixForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixForPrint.GetLength(1); j++)
        {
            System.Console.Write(matrixForPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}
//Ввод данных
int[] ReadInt(string text)
{
    System.Console.Write(text);
    return Array.ConvertAll(Console.ReadLine()!.Split(" "), int.Parse); ;
}
// перемножение мариц
int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] matrixResult = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                matrixResult[i, j] = matrixResult[i, j] + (matrix1[i, k] * matrix2[k, j]);
            }
        }
    }

    return matrixResult;
}

//..

System.Console.WriteLine("Операция умножения двух матриц выполнима только в том случае, если число столбцов в первом сомножителе равно числу строк во втором.");
int[] sizeA = ReadInt("Задайте количество строк и столбцов matrix1 через пробел: ");
int[,] matrix1 = FillMatrix(sizeA[0], sizeA[1], 0, 9);
// int[,] matrix1 = new int[2, 2]; // для проверки
// matrix1[0, 0] = 2; matrix1[0, 1] = 4;
// matrix1[1, 0] = 3; matrix1[1, 1] = 2;

int[] sizeB = ReadInt("Задайте количество строк и столбцов matrix2 через пробел: ");
int[,] matrix2 = FillMatrix(sizeB[0], sizeB[1], 0, 9);
// int[,] matrix2 = new int[2, 2]; // для проверки
// matrix2[0, 0] = 3; matrix2[0, 1] = 4;
// matrix2[1, 0] = 3; matrix2[1, 1] = 3;

System.Console.WriteLine("matrix1");
PrintMatrix(matrix1);
System.Console.WriteLine("matrix2");
PrintMatrix(matrix2);
if (matrix1.GetLength(0) == matrix2.GetLength(1))
{
    System.Console.WriteLine("Резултат перемножения матриц: ");
    PrintMatrix(MatrixMultiplication(matrix1, matrix2));
}
else
{
    System.Console.WriteLine("матрицы с введенными параметрами перемножить нельзя");
}