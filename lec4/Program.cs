// string[,] table = new string[2, 5];
//table[0, 0]   table[0, 1] ... table[0, 4]
//table[1, 0]   table[1, 1] ... table[1, 4]

// table[1, 2] = "слово";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }

// void Print(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void Fill(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// int[,] matrix = new int[3, 4];
// Print(matrix);
// Fill(matrix);
// Console.WriteLine();
// Print(matrix);

// int[,] pic = new int[,]
// {
//     {0, 0, 0, 0, 0, 0},
//     {0, 1, 0, 0, 1, 0},
//     {1, 0, 1, 1, 0, 1},
//     {1, 0, 0, 0, 0, 1},
//     {0, 1, 0, 0, 1, 0},
//     {0, 0, 1, 1, 0, 0},
// };

// void Print(int[,] image)
// {
//     for (int i = 0; i < image.GetLength(0); i++)
//     {
//         for (int j = 0; j < image.GetLength(1); j++)
//         {
            
//             if(image[i, j]==0) Console.Write(" ");
//             else Console.Write("+");
//         }
//         Console.WriteLine();
//     }
// }

// void Fill(int row, int col)
// {
//     if(pic[row, col]==0)
//     {
//         pic[row, col]=1;
//         Fill(row-1, col);
//         Fill(row, col-1);
//         Fill(row+1, col);
//         Fill(row, col+1);
//     }
// }


// Print(pic);
// Fill(3, 3);
// Print(pic);

// double Fact(int n)
// {
//     if(n == 1) return 1;
//     else return n*Fact(n-1);
// }


// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! = {Fact(i)}");
// }


int Fibo(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibo(n-1) + Fibo(n-2);
}

for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"f({i}) = {Fibo(i)}");
}