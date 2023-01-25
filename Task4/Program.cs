// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения для которых 
// лежат в отрезке (10-99).

//Инициализирует новый массив
int[] InitArray(int length)
{
    int[] array = new int [length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(-100, 300);
    }

    return array;
}

// Печатает массив на экран
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}

// Считает количество элементов массива в заданном диапазоне
int Count(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
     {
     if (array[i] >= 10 && array[i] <= 99) count++;
     }
     return count;
    
}

Console.WriteLine("Введите размер массива ");
int [] array = InitArray(int.Parse(Console.ReadLine()));

PrintArray(array);
Count(array);

Console.WriteLine($"Количество элементов массива в заданном диапазоне: {Count(array)}");
