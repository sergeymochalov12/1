// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] FillMatrix(int row, int col, int leftRange, int rightRange)// заливает массив случайными вещественными числами
{
    double [,] tempMatrix = new double [row, col];
    Random rand = new Random();
    //var rand = new Random();

    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i, j] = rand.Next(leftRange, rightRange + 1)/10.0;
        }
    }

    return tempMatrix;
}

int ReadInt(string text)// считывает параметр

{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
void PrintMatrix(double [,] matrixFotPrint)// выводит на экран массив
{
    for (int i = 0; i < matrixFotPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixFotPrint.GetLength(1); j++)
        {
            //System.Console.Write(matrixFotPrint[i, j] + "\t");
            Console.Write(String.Format(" {0,5:f1}", matrixFotPrint[i,j]));
        }
        System.Console.WriteLine();
    }
}

// ------------------------------ОСНОВНОЙ КОД-------------------------------------------

System.Console.WriteLine("Задайте двумерный массив размером m×n ");
int rows = ReadInt("Введите количество строк m = ");
int cols = ReadInt("Введите количество столбцов n = ");
double[,] matrix = FillMatrix(rows, cols, -100, 100);
PrintMatrix(matrix);
