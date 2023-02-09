// Найдите произведенеие пары чисел в одномерном массиве.
// Пару считаем 1+последнее число, 2+ предпоследнее...


int[] InitArray(int dimension)
{
    int[] result = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(2,7);
    }

    return result;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] GetChange(int[] array)
{
    int[] result; 
if (array.Length %2 ==0)
result = new int [array.Length/2];
else result = new int [array.Length/2+1];

for (int i = 0; i < array.Length/2; i++)
{
    result[i] = array[i] * array[array.Length-1-i];
}
if (array.Length %2 !=0) 
result[result.Length-1] = array[array.Length/2];
return result;
}

var array = InitArray(5);
PrintArray(array);
var result = GetChange(array);
PrintArray(result);