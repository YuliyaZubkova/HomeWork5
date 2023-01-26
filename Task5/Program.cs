// Найдите произведенеие пары чисел в одномерном массиве.
// Пару считаем 1+последнее число, 2+ предпоследнее...


/*Инициализирует новый массив
int[] InitArray(int length)
{
    Random rnd = new Random();
    int[] array = new int [length];
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(1, 5);
    }

    return array;
}


int[] NewArray(int[] array)
{
    int[] arr; 
    int len = 0;
    
    if (array.Length%2 == 0) 
    {
        len = array.Length/2;
        arr = new int[len];
    }
    else 
    {
        len = array.Length/2 + 1;
        arr = new int [len];
        arr[len-1] = array[len];

    }

    for (int i = 0; i < len; i++) // непонятно как сделать чтобы середина не умножалась на 2
    {
        arr[i] = array[i]*array[array.Length - i - 1];
    }
    return arr;
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

Console.WriteLine("Введите размер массива ");
int [] array = InitArray(int.Parse(Console.ReadLine()));
PrintArray(array);
int [] arr = NewArray(array);
Console.WriteLine();
PrintArray(arr);
*/


  static class func 
  { 
    static void Main() 
    { 
      Console.WriteLine("Размер массива: "); 
      int n; 
      n = Convert.ToInt32(Console.ReadLine()); 
      int[] ar = new int[n]; 
      var rand = new Random(); 
       
      for(int i = 0; i < ar.Length; i++) 
        ar[i] = rand.Next(-50, 50); 
      Console.Write("Значения элементов массива: "); 
      foreach(var item in ar) 
        Console.Write("{0} ", item); 
      Console.WriteLine(); 
      for(int i = 0; i < ar.Length / 2; i++) 
        Console.WriteLine("элемент {0} х элемент {1}, {2} х {3}  = {4}", i, ar.Length - i - 1, ar[i], ar[ar.Length - i - 1], ar[i] * ar[ar.Length - i - 1]); 
      return; 
    } 
  } 
