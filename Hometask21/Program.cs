// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 3D пространстве.

// // A (3,6,8); B (2,1,-7), -> 15.84

// // A (7,-5, 0); B (1,-1,9) -> 11.53

int x1 = InsertPosition("Введите первую координату X первой точки:");
int y1 = InsertPosition("Введите первую координату Y первой точки:");
int z1 = InsertPosition("Введите первую координату Z первой точки:");

int x2 = InsertPosition("Введите первую координату X второй точки:");
int y2 = InsertPosition("Введите первую координату Y второй точки:");
int z2 = InsertPosition("Введите первую координату Z второй точки:");



double res = LenghtLine(x1, x2, y1, y2, z1, z2);

double resRound = Math.Round(res, 2, MidpointRounding.ToZero);

Console.WriteLine($"Расстояние между точками равно: {resRound}");

int InsertPosition(string text)
{
    Console.WriteLine(text);
    int pos = Convert.ToInt32(Console.ReadLine);
    return pos;
}

double LenghtLine(int xpos1, int xpos2, int ypos1, int ypos2, int zpos1, int zpos2)
{
    int temp = (xpos1 - xpos2)*(xpos1-xpos2) + (ypos1 - ypos2)*(ypos1 - ypos2) + (zpos1 - zpos2)*(zpos1 - zpos2);
    return Math.Sqrt(temp);
}
