// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");




int num = new Random().Next(10, 100);
int a1 = num % 10;
int a2 = num / 10;

int max = a1;
if (a2 > max)
{
    max = a2;
}

Console.Write($"Max number is {max} from {num}");
