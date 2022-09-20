// ---------------------------------------------------------------------
//                                 Задача 36
// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// *Все пары в массиве [5,5]
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

int EvenSumPosition(int[] arr)
{
    int A = 0;
    for (int i = 1; i < arr.Length; i = i + 2)
    {
        A += arr[i];
    }
    return A;
}

int arrayLength = ReadData("Введите длину массива: ");
int downBorder = ReadData("Введите нижнюю границу заполнения массива: ");
int topBorder = ReadData("Введите верхнюю границу заполнения массива: ");

int[] inputArray = FillArray(arrayLength, downBorder, topBorder);
Print1DArr(inputArray);

int sumArray = EvenSumPosition(inputArray);

Console.WriteLine("Cумма элементов, стоящих на нечётных позициях: " + sumArray);
