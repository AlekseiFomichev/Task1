// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("введите пятизначное число");
int n = Convert.ToInt32(Console.ReadLine());
int temp = n;
int rev = 0;

while(n > 0) 
{
int r = n % 10;
rev = rev * 10 + r;
n = n / 10;
}
if(temp == rev)
Console.WriteLine("да");
else 
Console.WriteLine("нет");
