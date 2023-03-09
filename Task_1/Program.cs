/// <summary>
/// Метод содаёт двумерный массив целых 
/// рандомых чисел от 0 до 99
/// </summary>
/// <param name="rows">Количество строк</param>
/// <param name="cols">Количество столбцов</param>
/// <returns></returns>
int[,] GetMatrix(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = new Random().Next(100);
        }
    }
    return matrix;
}

/// <summary>
/// Метод выводит на экран двумерный массив
/// </summary>
/// <param name="matr">Двумерный массив</param>
void PrintMatrix(int[,] matr)
{
    int sizeRows = matr.GetLength(0);
    int sizeCols = matr.GetLength(1);
    for (int i = 0; i < sizeRows; i++)
    {
        for (int m = 0; m < sizeCols; m++)
        {
            Console.Write(matr[i, m] + "\t");
        }
        Console.WriteLine();
    }
}

/// <summary>
/// Медот считывает ввод с клавиатуры
/// и делает проверку на ввод только целых чисел
/// </summary>
/// <returns>Целое число</returns>
int ReadNumber()
{
    bool check = false;
    int number = 0;
    while (check == false)
    {
        string text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            check = true;
        }
        else
        {
            Console.WriteLine("Не удалось распознать число, поробуйте ещё раз");
        }
    }
    check = false;
    return number;
}

/// <summary>
///  Метод упорядочит по убыванию элементы 
///  каждой строки двумерного массива
/// </summary>
/// <param name="matr">Двумерный массив</param>
void ArrangeRows(int[,] matr)
{
    int sizeRows = matr.GetLength(0);
    int sizeCols = matr.GetLength(1);
    int temp;
    for (int i = 0; i < sizeRows; i++)
    {
        for (int m = 0; m < sizeCols; m++)
        {
            for (int j = m + 1; j < sizeCols; j++)
            {
                if (matr[i,m] < matr[i,j])
                {
                    temp = matr[i, m];
                    matr[i,m] = matr[i,j];
                    matr[i,j] = temp;
                }
            }
        }

    }
}

Console.WriteLine("Введите количество строк массива");
int rows = ReadNumber();
Console.WriteLine("Введите количество столбцов массива");
int cols = ReadNumber();
int[,] matrix = GetMatrix(rows, cols);
PrintMatrix(matrix);
Console.WriteLine("Упорядоченные стоки двумерного массива");
ArrangeRows(matrix);
PrintMatrix(matrix);