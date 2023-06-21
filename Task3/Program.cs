// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// (*) В 3-й задаче Доп сложность. Ввод с консоли “введите количество элементов массива”, “Введите минимальный порог случайных значений”, “Введите максимальный порог случайных значений”

int Enter(string text)
{
    System.Console.WriteLine(text);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[] MyArray(int size, int max, int min)
{
    Random rnd = new Random();

    int[] myArray = new int[size];

    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = rnd.Next(min, max + 1);

    }
    return myArray;
}

void printArray(int[] myArray)
{
    System.Console.Write("Array:[");
    for (int i = 0; i < myArray.Length; i++)
    {
        System.Console.Write($"_{myArray[i]}");
    }
    System.Console.Write("_]");
}

int size = Enter("Введите размер массива: ");

int min = Enter("Введите минимальное значение: ");

int max = Enter("Введите максимальное значение: ");

printArray(MyArray(size, max, min));
