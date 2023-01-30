// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int numberB = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int numA, int numB)
{
    if(numB == numA) return 0;
    return  (numB + numA)*(numB - numA +1)/2 ;  //формула суммы членов арифметической прогрессии
}
int num = SumNumbers(numberA, numberB);
Console.WriteLine($"M = {numberA}; N = {numberB} -> {num}");