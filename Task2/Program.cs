// Напишите программу замены элементов массива - положительные замените на отрицательные и наоборот


//Инициализирует новый массив
int[] InitArray(int length)
{
    int[] array = new int [length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(-9,10);
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


//Меняет числа на противоположные
void ChangeElements(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{-1*arr[i]}, ");
    }
    Console.WriteLine();
}

int[] arr = InitArray(4);
PrintArray(arr);
Console.WriteLine();
ChangeElements(arr);


