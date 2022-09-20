// ---------------------------------------------------------------------
//                                 Задача 34
// Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество
// чётных чисел в массиве.
// *Сортровка пузырком
// ---------------------------------------------------------------------

// Метод считывания данных пользователя
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

//Универсальный метод генерации и заполнения массива
int[] FillArray(int num, int downBorder, int topBorder)
{
    //Генератор случайных чисел
    Random numSintezator = new Random();
    //Создаем массив
    int[] arr = new int[num];
    //Тест границ
    if (downBorder < topBorder)
    {
        //Заполняем массив
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = numSintezator.Next(downBorder, topBorder + 1);
        }
    }
    //Возвращаем результат
    return arr;
}

//Печатае одномерный массив
void Print1DArr(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}

int EventCount(int[] arr)
{
    int A = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (EventTest(arr[i]))
            A++;
    }
    return A;

}

bool EventTest(int A)
{
    return A % 2 == 0;
}

int arrayLength = ReadData("Введите длину массива: ");
int downBorder = ReadData("Введите нижнюю границу заполнения массива: ");
int topBorder = ReadData("Введите верхнюю границу заполнения массива: ");

int[] inputArray = FillArray(arrayLength, downBorder, topBorder);
Print1DArr(inputArray);

int sumArray = EventCount(inputArray);

Console.WriteLine("Кол-во четных чисел: " + sumArray);
