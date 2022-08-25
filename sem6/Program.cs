// int[] Mas(int size, int min, int max)
// {
//     int[] arr = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = i + 1;//new Random().Next(min, max);
//     }
//     return arr;
// }

// int[] Revers(int[] arr)
// {
//     int[] result = new int[arr.Length];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         result[i] = arr[arr.Length - 1 - i];
//     }
//     return result;
// }


// int[] Revers2(int[] arr)
// {
//     for (int i = 0; i < arr.Length/2; i++)
//     {
//         int temp = arr[i];
//         arr[i] = arr[arr.Length - 1 -i];
//         arr[arr.Length - 1 -i] = temp;
//     }
//     return arr;
// }

// int[] mas = Mas(10, 1, 10);
// Console.Write(String.Join(" ", mas));
// Console.WriteLine();
// Console.Write(String.Join(" ", Revers(mas)));
// Console.WriteLine();
// Console.Write(String.Join(" ", Revers2(mas)));
////////////////////////////////////////////////////////////
// Console.Write("Enter the number 1: ");
// int num1 = int.Parse(Console.ReadLine());
// Console.Write("Enter the number 2: ");
// int num2 = int.Parse(Console.ReadLine());
// Console.Write("Enter the number 3: ");
// int num3 = int.Parse(Console.ReadLine());

// bool Trin(int a, int b, int c)
// {
//     return a < b + c && b < a + c && c < a + b;
// }

// if (Trin(num1, num2, num3)) Console.WriteLine("Yes");
// else Console.WriteLine("No");
///////////////////////////////////////////////////////////////////

// Console.Write("Enter the number: ");
// int number = int.Parse(Console.ReadLine());

// int Bin(int num)
// {
//     string result = "";
//     while (num != 0)
//     {
//         result += Convert.ToString(num % 2);
//         num /= 2;
//     }
    
//     result.ToCharArray().Reverse();
//     return int.Parse(result);
// }

// Console.WriteLine(Bin(number));

