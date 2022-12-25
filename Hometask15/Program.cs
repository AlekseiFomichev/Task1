// Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите целое число от 1 до 7");
string day = Console.ReadLine();
if (day == "1")
{
    Console.WriteLine("нет");
}
else if (day == "2")
{
   Console.WriteLine("нет"); 
}
else if (day == "3")
{
   Console.WriteLine("нет"); 
}
else if (day == "4")
{
   Console.WriteLine("нет"); 
}
else if (day == "5")
{
   Console.WriteLine("нет"); 
}
else if (day == "6")
{
   Console.WriteLine("да"); 
}
else if (day == "7")
{
Console.WriteLine("да");
}
else
{
Console.WriteLine("Только числа от 1 до 7 !!!");
}