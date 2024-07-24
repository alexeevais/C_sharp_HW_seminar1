// Проверка на четность
// Внутри класса Answer напишите метод CheckIfEven, который на вход принимает число number и выводит, является ли число чётным (делится ли оно на два без остатка).

// Пример использования:

// На входе:
// number: '6'
// На выходе:
// четное

// На входе:
// number: '3'
// На выходе:
// нечетное

Console.WriteLine("Введите целое число и нажмите Enter: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number % 2 == 0)
Console.WriteLine("четное");
else
Console.WriteLine("нечетное");
