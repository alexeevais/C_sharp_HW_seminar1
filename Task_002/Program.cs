
// Внутри класса Answer напишите метод FindMax, который принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите целое число и нажмите Enter: ");
int a = Convert.ToInt32(Console.ReadLine()); //int a = 5;
Console.WriteLine("Введите еще одно целое число и нажмите Enter: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье целое число и нажмите Enter: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;
if (max < b)
max = b;
if (max < c)
max = c;
Console.WriteLine($"Максимальное число: {max}");