// int num = new Random().Next(100, 1000);
// int a1 = num / 100;
// int a2 = (num % 100) / 10;
// int a3 = num % 10;
// int res = a1 * 10 + a3;
// Console.WriteLine($"The number is {num} and res is: {a1}, {a2}, {a3}");
// Console.Write($"The result number is: {res}");

// int num1 = new Random().Next(10, 100);
// int num2 = new Random().Next(1, 10);

// Console.WriteLine($"Enter two numbers:");
// int num1 = int.Parse(Console.ReadLine());
// int num2 = int.Parse(Console.ReadLine());

// if (num1 % num2 == 0)
// {
//     Console.WriteLine($"The number {num1} divided by {num2} WITHOUT remainder");
// }
// else
// {
//     Console.WriteLine($"The number {num1} divided by {num2} WITH remainder {num1 % num2}");
// }
Console.WriteLine($"Enter number:");
int num = int.Parse(Console.ReadLine());

if (num % (7 * 23) == 0)
{
    Console.WriteLine($"The number {num} divided by 7 and 23 WITHOUT remainder");
}
else
{
    Console.WriteLine($"The number {num} DON't divided by 7 and 23 without remainder");
}