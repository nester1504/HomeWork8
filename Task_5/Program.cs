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
    int startCol = 0;
    int endCol = cols - 1;
    int startRow = 0;
    int endRow = rows - 1;
    int counter = 1;
    while (startCol <= endCol && startRow <= endRow)
    {
        for (int i = startCol; i <= endCol; i++)
        {
            matrix[startRow, i] = counter;
            counter++;
        }
        startRow++;
        for (int i = startRow; i <= endRow; i++)
        {
            matrix[i, endCol] = counter;
            counter++;
        }
        endCol--;
        for (int i = endCol; i >= startCol; i--)
        {
            matrix[endRow, i] = counter;
            counter++;
        }
        endRow--;
        for (int i = endRow; i >= startRow; i--)
        {
            matrix[i, startCol] = counter;
            counter++;
        }
        startCol++;
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


Console.WriteLine("Введите количество строк массива");
int rows = ReadNumber();
Console.WriteLine("Введите количество столбцов массива");
int cols = ReadNumber();
int[,] matrix = GetMatrix(rows, cols);
PrintMatrix(matrix);