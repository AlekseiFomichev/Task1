// Напишите программу, которая принимает на вход число(N)
// и выдает таблицу квадратов чисел от 1 до N.
// 5 - > 1, 4, 9, 16, 25
// 2 - > 1, 4

Console.WriteLine("Введите натуральное число:");
int num = Convert.ToInt32(Console.ReadLine());
SquareNum(num);
// Используем невозвратный метод
void SquareNum(int number)
{
    int index = 1;
    while(index <= number)
    {
        Console.WriteLine($"{index} -> {index * index}");
        index++;
    }
}