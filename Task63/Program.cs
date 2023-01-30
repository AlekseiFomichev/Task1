// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"


int InsertDigit(string text) //Метод пользовательского ввода для целых чисел
{
    int result; bool parse;
    Console.WriteLine(text);
    parse = Int32.TryParse(Console.ReadLine(), out result);
    if (!parse) result = InsertDigit(text);//Если пользователь ввел некорректное значение вызываем повтороно метод.
    return result;
}


void IntegerNumbers(int n, int m, int s)
{
    if (n == m)
    {
        Console.Write($"{n} ");
        return;
    }
    IntegerNumbers(n + s, m, s);

    Console.Write($"{n} ");
}

int mUser = InsertDigit("Введите число N:");
int nUser = InsertDigit("Введите число M:");

int sign=Math.Sign((mUser-nUser));
Console.WriteLine($"sign = {sign}");

IntegerNumbers(nUser, mUser, sign);