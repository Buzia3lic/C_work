int num = new Random().Next(100, 1000);
int a1 = num / 100;
int a2 = (num % 100)/10;
int a3 = (num % 100)%10;
int res = a1*10 + a3;
Console.WriteLine($"The number is {num} and res is: {a1}, {a2}, {a3}");
Console.Write($"The result number is: {res}");
