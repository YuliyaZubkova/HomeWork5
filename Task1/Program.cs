// Задайте массив из 12 элементов, заполненный случайными числами из промежутка
// [-9, 9]. Найдите сумму отрицательных и положительных элементов массива. 

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

 
//Получает сумму положительных элементов в массиве
int GetPositiveSum(int[] arr)
{
    int summ = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0)
            summ += arr[i];
    }

    return summ;
}

//Получает сумму отрицательных элементов в массиве
int GetNegativeSum(int[] arr)
{
    int summ = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < 0)
            summ += arr[i];
    }

    return summ;
}

(int, int) GetPositiveAndNegativeSum(int[] array)
{
    int positive = 0;
    int negative = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            positive += array[i];
        else negative += array[i];
    }

    return (positive, negative);
}

int[] arr = InitArray(12);
PrintArray(arr);
//int positiveSum = GetPositiveSum(arr);
//int negativeSum = GetNegativeSum(arr);

(int pos, int neg) = GetPositiveAndNegativeSum(arr);

//Console.WriteLine($"Сумма положительных элементов: {positiveSum}, Сумма отрицательных элементов: {negativeSum}.");

Console.WriteLine($"Сумма положительных элементов: {pos}, Сумма отрицательных элементов: {neg}.");