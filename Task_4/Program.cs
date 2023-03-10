/// <summary>
/// Медот создаёт и заполняет трехмерный массив
/// </summary>
/// <param name="rows">Длина</param>
/// <param name="cols">Высота</param>
/// <param name="depth">Ширина</param>
/// <param name="array">Массив рандомных не повторяйщих целых чисел</param>
/// <returns>Трехмерный массив</returns>
int[,,] GetCube(int rows, int cols, int depth, int[] array)
{
    int countArray = 0;
    int[,,] cube = new int[rows, cols, depth];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                cube[i, j, k] = array[countArray];
                countArray++;
            }
        }
    }
    return cube;
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
/// Медот создаёт и заполняет массив рандомных не повторяйщих целых чисел
/// </summary>
/// <param name="size">Размер массива</param>
/// <returns>Массив рандомных не повторяйщих целых чисел</returns>
int[] ArrayOfUniqueNumbers(int size)
{
    int[] randomArray = new int[size];
    Random r = new Random();
    for (int i = 0; i < size; i++)
    {
        bool contains;
        int next;
        do
        {
            next = r.Next(10, 100);
            contains = false;
            for (int k = 0; k < i; k++)
            {
                int n = randomArray[k];
                if (n == next)
                {
                    contains = true;
                    break;
                }
            }
        } while (contains);
        randomArray[i] = next;
    }
    return randomArray;
}

/// <summary>
/// Метод проверки длины массива не более 90 чисел
/// </summary>
/// <param name="size">Длина массива</param>
void CheckSizeArray(int size)
{
    if (size >= 100)
    {
        Console.WriteLine("Данный трехмерный массив не может быть больше чем 90 уникальных чисел, запустите программу заново");
        Environment.Exit(0);
    }
    else
    {
    }
}

/// <summary>
/// Метод выводит на экран трехмерный массив 
/// </summary>
/// <param name="cube">Трехмерный массив</param>
void PrintCube(int[,,] cube)
{
    int sizeRows = cube.GetLength(0);
    int sizeCols = cube.GetLength(1);
    int sizeDepth = cube.GetLength(2);
    for (int i = 0; i < sizeRows; i++)
    {
        for (int m = 0; m < sizeCols; m++)
        {
            for (int k = 0; k < sizeDepth; k++)
            {
                Console.Write(cube[i, m, k] + "(" + i + "," + m + "," + k + ")"+"  ");
            }
            Console.WriteLine();
        }
        
    }
}

Console.WriteLine("Введите количество строк массива");
int rows = ReadNumber();
Console.WriteLine("Введите количество столбцов массива");
int cols = ReadNumber();
Console.WriteLine("Введите глубину массива");
int depth = ReadNumber();

int size = rows * cols * depth;

CheckSizeArray(size);
int[] arr = ArrayOfUniqueNumbers(size);

int[,,] cube = GetCube(rows,cols,depth,arr);

PrintCube(cube);



