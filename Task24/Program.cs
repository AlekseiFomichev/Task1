// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
// int number1 = Convert.ToInt32(Console.ReadLine());

// int sumNumbers = SumNumbers(number);
Console.WriteLine($"сумма чисел от 1 до {number} = {sumNumbers(number)}");

int SumNumbers (int num) //num = number
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum = sum + 1;
    }
    return sum;
}