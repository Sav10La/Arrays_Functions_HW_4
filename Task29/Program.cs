// Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
//-2, 1, 7, 5, 19 -> [1, -2, 5, 7, 19]
//6, 1, -33 -> [1, 6, -33]

Zadacha29();
void Zadacha29()
{
    int size = 8;
    int[] array = new int[size];
    array = FillArray(size);
    PrintArray(array);
    AbsSort(array);
    PrintArray(array);
}

int[] FillArray(int size)
{
    int[] fillArray = new int[size];
    Random random = new Random();
    for (int i = 0; i < fillArray.Length; i++)
    {
        fillArray[i] = random.Next(-50,50);
    }
    return fillArray;
}

void PrintArray(int[] array)
{
    Console.WriteLine("Вывод массива");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void AbsSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length - 1; j++)
        {
            if (Math.Abs(array[j]) < Math.Abs(array[minPosition]))
            minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;

        array[i] = Math.Abs(array[i]);
    }
}