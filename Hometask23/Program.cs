// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.WriteLine("Введите натуральное число:");
int num = Convert.ToInt32(Console.ReadLine());
SquareNum(num);
// Используем невозвратный метод
void SquareNum(int number)
{
    int index = 1;
    while(index <= number)
    {
        Console.WriteLine($"{index} | {index * index * index}");
        index++;
    }
}