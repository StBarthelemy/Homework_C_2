Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int a = number / 100;
int b = number % 10;
int c = (number - a*100 - b)/10;
Console.WriteLine($"{number}");
Console.WriteLine($"{c}");