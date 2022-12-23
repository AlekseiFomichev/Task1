// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// int number = new Random().Next(100, 1000);
// Console.WriteLine($"Случайное трехзначное число {number}");
// int firstDigit = number / 100;
// int thirdDigit = number % 10;

// int result = firstDigit * 10 + thirdDigit;
// Console.WriteLine(result);

// Решение через метод ниже:

int rnd = new Random().Next(100, 1000);

int MakeDigit(int number)
{
    int result = (number/100)*10 + number % 10;
    return result;
}
int newDigit = MakeDigit(rnd);
Console.WriteLine($"{rnd} -> {newDigit}");