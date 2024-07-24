// Внутри класса Answer напишите метод CompareNumbers, который на вход принимает два числа и выводит, какое число большее, а какое меньшее.

// Пример использования:

// На входе:
// firstNumber: '5'
// secondNumber: '6'
// На выходе:
// второе число больше

// На входе:
// firstNumber: '6'
// secondNumber: '3'
// На выходе:
// первое число больше

// На входе:
// firstNumber: '3'
// secondNumber: '3'

// На выходе:
// числа равны

Console.WriteLine("Введите целое число и нажмите Enter: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите еще одно целое число и нажмите Enter: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
    Console.WriteLine("первое число больше");
if (firstNumber < secondNumber)
    Console.WriteLine("второе число больше");
if (firstNumber == secondNumber)
    Console.WriteLine("числа равны");