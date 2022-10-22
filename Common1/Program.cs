
int number = new Random().Next(100, 1000);

Console.WriteLine(number); 

int a1 = number % 10;
int number2 = ( number - a1 ) / 10;
int a2 =  number2 % 10;
int number3 = ( number2 - a2 ) / 10;
int number4 = number3 * 10 + a1;

Console.WriteLine(number4);

