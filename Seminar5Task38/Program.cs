// ---------------------------------------------------------------------
//                                 Задача 38
// Задайте массив вещественных чисел. Найдите разницу между
// максимальным и минимальным элементов массива.
// * +2 метода сортировки (Вставкой и подсчетом)
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
double[] FillArray(int num)
{
    //Генератор случайных чисел
    Random numSintezator = new Random();
    //Создаем массив
    double[] arr = new double[num];
    //Заполняем массив
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(numSintezator.NextDouble(), 2);
    }
    //Возвращаем результат
    return arr;
}

//Печатае одномерный массив
void Print1DArr(double[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}

double MaxMin(double[] arr)
{

    double max = int.MinValue;
    double min = int.MaxValue;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    return (max - min);
}


int arrayLength = ReadData("Введите длину массива: ");

double[] inputArray = FillArray(arrayLength);
Print1DArr(inputArray);

double sumArray = MaxMin(inputArray);

Console.WriteLine("Разница: " + Math.Round(sumArray, 2));