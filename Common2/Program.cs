Console.Write("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int rem1 = number1 / number2;
int rem2 = number1 % number2;

if ( rem2 != 0)
{
    Console.WriteLine($"Не кратно, остаток {rem2}");
}
else
{
    Console.WriteLine("Кратно");
}