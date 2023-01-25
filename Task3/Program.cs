// Программа проверяет есть ли число, введенное с консоли в заданном массиве. 


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

// Проверяет есть ли число, введенное с консоли
bool Exist(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num) return true; 
    }
    return false;
}

int [] array = InitArray(5);
PrintArray(array);
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Exist(array, num));


