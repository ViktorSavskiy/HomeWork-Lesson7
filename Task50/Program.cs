int[,] GetArray (int m, int n)
{
    int[,] result = new int[m,n];
    for (int i=0; i<m; ++i)
{
for (int j = 0; j < n; j++)
{
    result[i,j] = new Random().Next(); 
}
}
return result;
}
void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
       for (int j = 0; j < array.GetLength(1); j++)
       {
        Console.Write(array[i,j] + "   //  ");
       } 
       Console.WriteLine();
    }
}
Console.Write("Введите количество строк - ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов - ");
int columns = int.Parse(Console.ReadLine());
int[,] array = GetArray(rows,columns);
PrintArray(array);

Console.Write("Задайте число - ");
int numbers = int.Parse(Console.ReadLine());
int sum = 0;
foreach(int el in array)
{
sum += el == numbers ? el : 0;
}

if (sum == numbers)
{
    Console.WriteLine(numbers + " - Такое число в массиве есть");
}
else
{
Console.WriteLine(numbers + " - Такого числа в массиве нет");
}

