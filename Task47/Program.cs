double[,] getArray(int m, int n)
{
    double[,] result = new double[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().NextDouble();
        }
    }
    return result;
}

void printArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " // ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите количество строк");
int rouws = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = int.Parse(Console.ReadLine());

double[,] result = getArray(rouws, columns);
printArray(result);