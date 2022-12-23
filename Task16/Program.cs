// Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Введите целое первое число и нажмите Enter");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое второе число и нажмите Enter");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(IsSqare(number1, number2) ? "да" : "нет");

bool IsSqare(int n1, int n2)
{
    return n1 / n2 == n2 || n2 / n1 == n1;
}