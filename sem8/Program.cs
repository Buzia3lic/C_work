int[,] GetArrey(int m, int n)
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
        for (int j = 0; j < arr.GetLength(1); j++) Console.Write($"{arr[i, j]} ");
        Console.WriteLine();
    }
}

int[,] TurnMatrix(int[,] arr)
{
    int[,] newArr = new int[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++) newArr[j, i] = arr[arr.GetLength(0) - 1 - i, j];
    return newArr;
}

void CheckArray(int m, int n)
{
    if (m != n)
    {
        Console.WriteLine("Numbers are different! We cannot do the turn.");
    }
    else
    {
        Console.WriteLine("Numbers are equel! Let's do this...");
        int[,] newMas = GetArrey(m, n);
        PrintArr(newMas);
        Console.WriteLine();
        int[,] turmArr = TurnMatrix(newMas);
        PrintArr(turmArr);
    }
}

// int[,] ChangeArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(1); i++)
//     {
//         (arr[0, i], arr[arr.GetLength(0) - 1, i]) = (arr[arr.GetLength(0) - 1, i], arr[0, i]);            
//     }
//     return arr;
// }

// Console.Write("Enter M: ");
// int m = int.Parse(Console.ReadLine());
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine());
// int[,] newMas = GetArrey(m, n);
// PrintArr(newMas);
// ChangeArray(newMas);
// Console.WriteLine();
// PrintArr(newMas);

Console.Write("Enter M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Enter N: ");
int n = int.Parse(Console.ReadLine());
CheckArray(m, n);
