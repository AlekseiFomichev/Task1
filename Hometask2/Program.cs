//  Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число большее, а
// какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите число и нажмите Enter");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число и нажмите Enter");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine($"Первое число {a} больше числа {b}");
}
else
{
        Console.WriteLine($"Первое число {a}  меньше {b}");
}