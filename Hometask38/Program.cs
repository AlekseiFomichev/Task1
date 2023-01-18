// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.NextDouble()*(max - min) + min;
    }
    return array;
}


void PrintArrayDouble(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write (Math.Round(array[i], 2, MidpointRounding.ToZero) + "; ");
        else Console.Write (Math.Round(array[i], 2, MidpointRounding.ToZero));
    }
    Console.WriteLine("]");
}


double MinValue(double[] array)
{
    double minValue = Double.MaxValue;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minValue)
        {
            minValue = array[i];
        }
    }

    return minValue;
}

double MaxValue(double[] array)
{
    double maxValue = Double.MinValue;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > maxValue)
        {
            maxValue = array[i];
        }
    }

    return maxValue;
}

double Difference(double[] array) => MaxValue(array) - MinValue(array);
double[] arr = CreateArrayRndDouble(8, 0, 10);
PrintArrayDouble(arr);
Console.WriteLine(Math.Round(Difference(arr), 2, MidpointRounding.ToZero));
