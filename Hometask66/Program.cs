// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

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