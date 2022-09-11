int[,] GetArray (int m, int n)
{
    int[,] result = new int[m,n];
    for (int i=0; i<m; ++i)
{
for (int j = 0; j < n; j++)
{
    result[i,j] = new Random().Next(0,10); 
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

int[] sum = new int[columns];
double[] Avarage = new double [columns];



for (int j = 0; j < columns; j++)
{
    for (int i = 0; i < rows; i++)
    {
               sum[j] += array[i, j];
        Avarage[j] = sum[j] / rows;
       
}
 Console.Write(Avarage[j] + " // ");
    }
    
   