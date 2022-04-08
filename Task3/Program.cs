Console.Clear();
Console.WriteLine("Введите длину массива:" );
int v = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите высоту массива:" );
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите ширину массива:" );
int k = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [n,v];

int findSame (int [,] mat)
{
    int a = new Random().Next(10,99);
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < v; j++)
        {
            if (mat[i, j] == a) { a++; };
        }
    }
    return a;
}

void FillArray(int [,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            mat[i,j] = findSame(matrix);
        }
    }
}

void PrintArray(int [,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            Console.Write($"{mat[i,j]} ");
        }

        Console.WriteLine();
    }
    Console.WriteLine();
}
for (int i = 0; i < k; i++)
{
    FillArray(matrix);
    PrintArray(matrix);
}