/* Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

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

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}

int GetPositiveSum(int[] arr)
{
    int summ = 0;
    for (int i = 1; i < arr.Length; i = i+2)
    {
            summ = summ + arr[i];
    }
    Console.WriteLine($"Сумма элементов нечетных позиций равна {summ}");
    return summ;
}

int[] arr = InitArray(6);
PrintArray(arr);
GetPositiveSum(arr); 

