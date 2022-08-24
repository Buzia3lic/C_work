// int[] Mas(int size, int min, int max)
// {
//     int[] arr = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = new Random().Next(min, max + 1);
//     }
//     return arr;
// }

// int[] mas = Mas(12, -9, 9);

// Console.WriteLine(String.Join(" ", mas));

// int plusSum = 0;
// int minusSum = 0;

// foreach (int el in mas)
// {
//     plusSum += el > 0 ? el : 0;
//     minusSum += el < 0 ? el : 0;
// }

// Console.WriteLine($"Plus sum: {plusSum}, minus sum: {minusSum}");

// int[] Mas(int size, int min, int max)
// {
//     int[] arr = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = new Random().Next(min, max + 1);
//     }
//     return arr;
// }

// int[] mas = Mas(4, -9, 9);

// Console.WriteLine(String.Join(" ", mas));

// int[] revers(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] *= -1;
//     }
//     return arr;
// }

// Console.WriteLine(String.Join(" ", revers(mas)));

// int[] Mas(int size, int min, int max)
// {
//     int[] arr = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = new Random().Next(min, max + 1);
//     }
//     return arr;
// }

// int[] mas = Mas(4, -9, 9);

// Console.WriteLine(String.Join(" ", mas));

// bool Find(int[] arr, int f)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] == f) return true;
//     }
//     return false;
// }

// Console.Write("Число для поиска: ");
// int find = int.Parse(Console.ReadLine());

// if (Find(mas, find)) Console.WriteLine("Yes");
// else Console.WriteLine("No");

int[] Mas(int size, int min, int max)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}

int[] mas = Mas(5, 0, 10);
Console.WriteLine(String.Join(" ", mas));

// int amount(int[] arr)
// {
//     int a = 0;

//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] >= 10 && arr[i] <= 99) a += 1;
//     }

//     return a;
// }

// Console.WriteLine($"Answer: {amount(mas)}");

///////////////////////////////////////

int[] ResultArray(int[] array)
{
int size = array.Length / 2;
if (array.Length % 2 == 1) size++;
int[] result = new int[size];
for (int i = 0; i < array.Length / 2; i++)
{

result[i] = array[i] * array[array.Length - 1 - i];
}
if (array.Length % 2 == 1) result[size-1] = array[array.Length / 2];
return result;
}

int[] group = ResultArray(mas);
Console.WriteLine(String.Join(" ", group));
