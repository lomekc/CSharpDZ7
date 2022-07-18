/*
// задача 47
double[,] RandomArray(int a, int b)
{
    while (a <= 0)
    {
        Console.Write("Строки должны быть больше нуля: ");
        a = Convert.ToInt32(Console.ReadLine());
    }

    while (b <= 0)
    {
        Console.Write("Столбцы должны быть больше нуля: ");
        b = Convert.ToInt32(Console.ReadLine());
    }
    
    double[,] newArray = new double[a, b];

    for (int i = 0; i < a; i++)
        for (int j = 0; j < b; j++)
            newArray[i, j] = (new Random().Next(1, 12)) + new Random().NextDouble();

    return newArray;
}

void ShowArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(array[i, j], 1);
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] myArray = RandomArray(m, n);

Console.WriteLine("Сгенерированный двумерный массив:");

ShowArray(myArray);
*/

// задача 50

double[,] RandomArray(int a, int b)
{
    while (a <= 0)
    {
        Console.Write("Строки должны быть больше нуля: ");
        a = Convert.ToInt32(Console.ReadLine());
    }

    while (b <= 0)
    {
        Console.Write("Столбцы должны быть больше нуля: ");
        b = Convert.ToInt32(Console.ReadLine());
    }

    double[,] newArray = new double[a, b];

    for (int i = 0; i < a; i++)
        for (int j = 0; j < b; j++)
            newArray[i, j] = (new Random().Next(1, 10));

    return newArray;
}

void ShowArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}  ");

        Console.WriteLine();
    }
}
/*
void ElementValue(double[,] array, int c, int d)
{
    int row = c;
    int column = d;

    if (row >= 0 && row < array.GetLength(0))
    {
        if (column >= 0 && column < array.GetLength(1))
        {
            Console.Write("Значение указанного элемента: " + array[row, column]);
        }
        else Console.Write("ошибка в указании столбца");
    }
    else Console.Write("ошибка в указании строки");
}

int m = new Random().Next(3, 11);
int n = new Random().Next(3, 11);

double[,] myArray = RandomArray(m, n);

Console.WriteLine("сгенерированный двумерный массив:");

ShowArray(myArray);

Console.Write("искомая строка - ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("искомый столбец - ");
int c = Convert.ToInt32(Console.ReadLine());

ElementValue(myArray, r, c);
*/
// задача 52, ввод массива из 50-ой задачи
void Average(double[,] twodarray)
{

    for (int l = 0; l < twodarray.GetLength(1); l++)
    {
        double sum = 0;
        for (int k = 0; k < twodarray.GetLength(0); k++)
        {
            sum = sum + twodarray[k, l];
        }
        double average = sum / twodarray.GetLength(0);
        average = Math.Round(average, 1);
        Console.WriteLine("Среднее арифметическое " + $"{l+1}" + " столбца: " + average);
    }
}

int m = new Random().Next(3, 11);
int n = new Random().Next(3, 11);

double[,] myArray = RandomArray(m, n);

Console.WriteLine("Сгенерированный двумерный массив:");

ShowArray(myArray);

Average(myArray);