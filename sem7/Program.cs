int[,] GetArrey (int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}

void PrintArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j]} ");
        Console.WriteLine();
    }

}

int[,] Sqr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            if (i % 2 == 0 && j % 2 == 0) arr[i, j] *= arr[i, j];
    }
    return arr;
}

int DiagSum(int[,] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            if (i == j) sum += arr[i, j];
    }
    return sum;
}

Console.Write("Enter M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Enter N: ");
int n = int.Parse(Console.ReadLine());
int[,] array = GetArrey(m, n);
PrintArr(array);
Console.WriteLine();
PrintArr(Sqr(array));
Console.WriteLine();
Console.WriteLine($"Sum is {DiagSum(array)}");
