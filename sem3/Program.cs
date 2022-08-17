
// Console.Write("Enter section number: ");
// int section = int.Parse(Console.ReadLine());

// switch(section)
// {
//     case 1:
//     {
//         Console.Write("X > 0, Y > 0");
//         break;
//     }
//     case 2:
//     {
//         Console.Write("X < 0, Y > 0");
//         break;
//     }
//     case 3:
//     {
//         Console.Write("X < 0, Y < 0");
//         break;
//     }
//     case 4:
//     {
//         Console.Write("X > 0, Y < 0");
//         break;
//     }
//     default:
//     {
//         Console.Write("Section must be between 1 to 4!");
//         break;
//     }
// }

// Console.Write("Enter X0: ");
// int x0 = int.Parse(Console.ReadLine());
// Console.Write("Enter Y0: ");
// int y0 = int.Parse(Console.ReadLine());
// Console.Write("Enter X1: ");
// int x1 = int.Parse(Console.ReadLine());
// Console.Write("Enter Y1: ");
// int y1 = int.Parse(Console.ReadLine());
// if (x0 == x1 && y0 == y1) 
// { 
//     Console.Write("The coordinates of the points are the same!"); 
// }
// else
// {
//     double length = Math.Sqrt(Math.Pow(x0 - x1, 2) + Math.Pow(y0 - y1, 2));
//     Console.Write($"The length is: {length:f2}");
// }

Console.Write("Enter number: ");
int num = int.Parse(Console.ReadLine());
Console.Write($"All squares of numbers from 1 to {num}: ");
int i = 0;
for (i = 1; i < num; i++)
{
    Console.Write($"{i}^2={Math.Pow(i, 2)}, ");
}
Console.Write($"{i}^2={Math.Pow(i, 2)}.");