// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int result = 0;

int SumNumbers(int num)
{
for(int i = 0; i < number; i++)
{
    sum = num - num % 10;
    result = result + (num - sum);
    num = num / 10;
    
}
return result;
}

Console.WriteLine(SumNumbers);