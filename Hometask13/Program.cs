// Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей
// цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


// Console.Write("Введите число,чтобы узнать 3 цифру, и нажмите Enter:");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number < 100)
// {
//     Console.WriteLine("Третьей цифры нет");
// }
// else
// {
//     while(number <= 999)
//     {
//         number--;
//     }
//     Console.WriteLine(number % 10);
// }

Console.Write("Введите число,чтобы узнать 3 цифру, и нажмите Enter: "); 
int numberA = Convert.ToInt32(Console.ReadLine()); 
 
void ThirdDigit(int num) 
{ 
    int counter = 1; 
    int result = num / 10; 
    while (counter < result) 
    { 
        if (result < 10) 
        { 
            Console.WriteLine("Третьей цифры нет"); 
        } 
        else if (10 * counter <= result & result < 100 * counter) 
        { 
            Console.WriteLine($"Третья цифра - {num / counter % 10}"); 
        } 
        counter *= 10; 
    } 
}  
ThirdDigit(numberA);