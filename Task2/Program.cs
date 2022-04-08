Console.Clear();
Console.WriteLine("Введите количество строк первой матрицы:" );
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первой матрицы:" );
int v = Convert.ToInt32(Console.ReadLine());
int [,] matrix1 = new int [n,v];
Console.WriteLine("Введите количество строк второй матрицы:" );
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов второй матрицы:" );
int p = Convert.ToInt32(Console.ReadLine());
int [,] matrix2 = new int [m,p];
int [,] resultMatrix = new int [n, p];

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
}

void FillArray(int [,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            mat[i,j] = new Random().Next(1,101);
        }
    }
}

Console.WriteLine();
FillArray (matrix1);
PrintArray(matrix1);
Console.WriteLine();
Console.WriteLine(" * ");
Console.WriteLine();
FillArray(matrix2);
PrintArray(matrix2);
Console.WriteLine();
Console.WriteLine(" = ");
Console.WriteLine();

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        for (int z = 0; z < n; z++)
        {
            resultMatrix[i, z] += matrix1[i, j] * matrix2[j, z];
        }
    }
}
PrintArray(resultMatrix);