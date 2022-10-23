Console.Write("Введите число 1: ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Введите число 2: ");
int number2 = int.Parse(Console.ReadLine());

double result = Math.Pow(number1, 2);

if (result == number2)
{
    Console.WriteLine($"Число {number1} квадрат {number2}");
}
else Console.WriteLine($"Число {number1} не квадрат {number2}");
