Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int rem1 = number % 23;
int rem2 = number % 7;

if(rem1 == 0 && rem2 == 0)
{
    Console.WriteLine($"Число {number} кратно 7 и 23.");
}
else Console.WriteLine($"Число {number} не кратно 7 и 23.");