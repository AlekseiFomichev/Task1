// Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трёхзначное число и нажмите Enter:");
int b = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(b);
Console.WriteLine("вторая цифра заданного числа -> " + stringNumber[1]);
