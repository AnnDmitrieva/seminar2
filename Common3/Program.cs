Console.Write("Введите число 1: ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Введите число 2: ");
int number2 = int.Parse(Console.ReadLine());

double result1 = Math.Pow(number1, 2);
double result2 = Math.Pow(number2, 2);

if (result1 == number2)
{
    Console.WriteLine($"Число {number1} квадрат {number2}");
}
else 
    if (result2 == number1)
    {
        Console.WriteLine($"Число {number2} квадрат {number1}");
    }
     else Console.WriteLine($"Число {number1} не квадрат {number2}");
