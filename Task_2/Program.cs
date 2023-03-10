/// <summary>
/// Метод содаёт двумерный массив целых 
/// рандомых чисел от 0 до 9
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
            matrix[i, j] = new Random().Next(10);
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
///  Метод находит строку с 
///  наименьшей суммой элементов
/// </summary>
/// <param name="matr">Двумерный массив</param>
/// <returns></returns>
int SumOfLineElements(int[,] matr)
{
    int minSum = 0;
    int minSum2 = int.MaxValue;
    int count = 0;
    int sizeRows = matr.GetLength(0);
    int sizeCols = matr.GetLength(1);

    for (int i = 0; i < sizeRows; i++)
    {
        for (int m = 0; m < sizeCols; m++)
        {
            minSum = minSum + matr[i, m];
        }
        Console.WriteLine(minSum);
        if (minSum < minSum2)
        {
            minSum2 = minSum;           
            count = i+1;
        }
        minSum = 0;
        
    }
    return count;
}

Console.WriteLine("Введите количество строк массива");
int rows = ReadNumber();
Console.WriteLine("Введите количество столбцов массива");
int cols = ReadNumber();
int[,] matrix = GetMatrix(rows, cols);
PrintMatrix(matrix);
int minRows = SumOfLineElements(matrix);
Console.WriteLine($"Наименьшей суммой элементов: {minRows} строка");