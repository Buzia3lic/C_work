// Console.Write("Введите число А: ");
// int num = int.Parse(Console.ReadLine());
// int Sums(int num)
// {
//     int sum = 0;
//     for (int i = 1; i <= num; i++)
//     {
//         sum += i;
//     }
//     return sum;
// }
// Sums(num);
// Console.WriteLine($"Сумму от 1 до {num} равна: {Sums(num)}");

// Console.Write("Введите число А: ");
// int num = int.Parse(Console.ReadLine());
// int amount(int num)
// {
//     int count = 0;
//     while ( num != 0)
//     {
//         count ++;
//         num /= 10;
//     }
//     return count;
// }
// Console.Write($"В числе {amount(num)} цифр.");


// Console.Write("Введите число А: ");
// int num = int.Parse(Console.ReadLine());
// int Mult(int a)
// {
//     int mul = 1;
//     for (int i = 1; i <= a; i++)
//     {
//         mul *= i;
//     }
//     return mul;
// }
// Mult(num);
// Console.WriteLine($"Умножение от 1 до {num} равна: {Mult(num)}");

Console.Write("Введите число А: ");
int num = int.Parse(Console.ReadLine());
void RandArr(int leng)
{
    int[] arr = new int[leng];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 2);
        Console.Write($"{arr[i]} ");
    }

    Console.WriteLine();
    Console.WriteLine($"{String.Join(",", arr)}");
}
RandArr(num);