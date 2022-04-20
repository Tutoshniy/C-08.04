Console.Clear();
Console.WriteLine("Введите количество строк первой матрицы:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первой матрицы:");
int v = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = new int[n, v];
Console.WriteLine("Введите количество строк второй матрицы:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов второй матрицы:");
int p = Convert.ToInt32(Console.ReadLine());
int[,] matrix2 = new int[m, p];
int[,] resultMatrix = new int[n, p];

void PrintArray(int[,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            Console.Write($"{mat[i, j]} ");
        }

        Console.WriteLine();
    }
}

void FillArray(int[,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            mat[i, j] = new Random().Next(1, 101);
        }
    }
}
void Prod(int[,] mat1, int [,] mat2, int [,] resMat)
{
    if (mat1.GetLength(1) == mat2.GetLength(0))
    {
    for (int i = 0; i < mat1.GetLength(0); i++)
            {
                for (int j = 0; j < mat2.GetLength(1); j++)
                {
                    for (int k = 0; k < mat2.GetLength(0); k++)
                    {
                        resMat[i,j] += mat1[i,k] * mat2[k,j];
                    }
                }
            }
    Console.WriteLine("Произведение матриц равно");
    PrintArray(resMat);
    }
    else Console.WriteLine ("Произведение невозможно");
}

Console.WriteLine();
FillArray(matrix1);
PrintArray(matrix1);
Console.WriteLine();
Console.WriteLine(" * ");
Console.WriteLine();
FillArray(matrix2);
PrintArray(matrix2);
Console.WriteLine();
Console.WriteLine(" = ");
Console.WriteLine();
Prod(matrix1, matrix2, resultMatrix);
