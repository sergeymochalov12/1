
//  Функция заполнения массива
void FillArraySpiral(int[,] array, int n, int m)
{
    int Ibeg = 0;
    int Ifin = 0;
    int Jbeg = 0;
    int Jfin = 0; // для обхода задаем i и j начальное и конечное

    int k = 1;// начинаем заполнять массив с переменной k
    int i = 0;
    int j = 0;

    while (k <= m * n)// всего чисел будет N X M 
    {
        array[i, j] = k;// заполняем массив
        if (i == Ibeg && j < m - Jfin - 1)// заполняем по горизонтали пока не уперлись в конец
            ++j;
        else if (j == m - Jfin - 1 && i < n - Ifin - 1)//заполняем вниз пока не  уперлись в конец
            ++i;
        else if (i == n - Ifin - 1 && j > Jbeg)// заполняем влево пока не уперлись в накчало
            --j;
        else // заполняем вверх
            --i;

        if ((i == Ibeg + 1) && (j == Jbeg) && (Jbeg != m - Jfin - 1))// условие при котором понятно что прямоугольник закончен
        {
            // уменьшаем прямоугольник 
            ++Ibeg;
            ++Ifin;
            ++Jbeg;
            ++Jfin;
        }
        ++k;
        //System.Console.WriteLine($"k={k} i={i} j={j} Ibeg={Ibeg} Ifin={Ifin} Jbeg={Jbeg} Jfin={Jfin} {Jbeg} != {m} - {Jfin} - 1");
    }
}

//  вывод двумерного массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("00" + array[i, j]); // если элемент меньше 10 то пишем 00 впереди чтоб было красиво
                Console.Write(" ");
            }
            else if (array[i, j] < 100)
            {
                Console.Write("0" + array[i, j]); // если элемент меньше 100 то пишем 0 впереди чтоб было красиво
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
//ОСНОВНОЙ КОД

int len = 4; // длина массива
int wid = 4; // ширина массива
int[,] table = new int[len, wid];
FillArraySpiral(table, len, wid);
PrintArray(table);

