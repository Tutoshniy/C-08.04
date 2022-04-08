Console.Clear();
Console.WriteLine("Введите количество строк:" );
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:" );
int k = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [n,k];

void PrintArray(int [,] mat)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < k; j++)
        {
            Console.Write($"{mat[i,j]} ");
        }

        Console.WriteLine();
    }
}

void FillArray(int [,] mat)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < k; j++)
        {
            mat[i,j] = new Random().Next(1,101);
        }
    }
}

if (n == k)
{
    FillArray(matrix);
    Console.WriteLine("Данный массив: ");
    PrintArray(matrix);
    for (int i = 0; i < n; i++)
    {
        for (int j = i; j < k; j++)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix [j, i];
            matrix[j, i] = temp;
        }
        
    }
    Console.WriteLine();
    Console.WriteLine("Получившийся массив: ");
    PrintArray(matrix);
}
else
{
    Console.WriteLine("Невозможно поменять числа местами");
}