/* Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

double [] InitArray(int dimension)
{
    double[] array = new double [dimension];
    Random rnd = new Random();
    for (int i = 0; i < dimension; i++)
    {
        array[i] = rnd.Next(1,100);
    }

    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}

double GetMax(double[] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > max)
            max = arr[i];
    }

    return max;
}

double GetMin(double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < min)
            min = arr[i];
    }

    return min;
}

double[] arr = InitArray(5);
PrintArray(arr);

double max = GetMax(arr);
double min = GetMin(arr);

Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {max-min}");