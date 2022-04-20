Console.Clear();
Console.WriteLine("Введите длину массива:" );
int v = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите высоту массива:" );
int k = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите ширину массива:" );
int n = Convert.ToInt32(Console.ReadLine());
int [,,] matrix = new int [n,v,k];

int findSame (int [,,] mat)
{
    int a = new Random().Next(10,99);
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            for(int k = 0; k < mat.GetLength(2); k++)
            {
                if (mat[i, j, k] == a) { a++; };

            }
        }
    }
    return a;
}

void FillArray(int [,,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            for(int k = 0; k < mat.GetLength(2); k++)
            {
                mat[i,j,k] = findSame(matrix);
            }

        }
    }
}

void PrintArray(int [,,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            for(int k = 0; k < mat.GetLength(2); k++)
            {
                Console.Write($"{mat[i,j,k]} ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
    }
    Console.WriteLine();
}

FillArray(matrix);
PrintArray(matrix);
