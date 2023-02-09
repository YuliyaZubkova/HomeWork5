/* Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/


int[] InitArray(int dimension)
{
    int[] array = new int[dimension];
    Random rnd = new Random();
    for (int i = 0; i < dimension; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }

    return array;
}

int PrintArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) sum = sum + 1;
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
    Console.WriteLine($"Количество четных чисел в массиве равно {sum} ");
    return sum;
}

int[] arr = InitArray(4);
PrintArray(arr);
