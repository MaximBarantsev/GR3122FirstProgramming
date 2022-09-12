// ---------------------------------------------------------------------
//                                 Задача 29
// Напишите программу, которая задаёт массив из 8 элементов и
// выводит их на экран.
// ---------------------------------------------------------------------


int ReadData(string line)
{

    Console.Write(line);                                   //Выводим сообщение

    int number = int.Parse(Console.ReadLine() ?? "0");     //Считываем и преобразуем число

    return number;                                         //Возвращаем значение
}

int[] GenArray(int arrLength, int start, int stop)
{
    int[] array = new int[arrLength];                      //Создаем новый массив
    Random ren = new Random();                             //Создаем рандомайзер

    for (int i = 0; i < arrLength; i++)                    //Создаем цикл для заполнения массива
    {
        array[i] = ren.Next(start, stop);                  //Заполняем массив
    }
    return array;                                          //Возвращаем значения
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)               //Создаем цикл для печати массива
    {
        Console.Write(arr[i] + ", ");                      //Выводим массив в консоль
    }
    Console.WriteLine(arr[arr.Length - 1]);                //Выводим последнее значение массива в консоль
}

int array = ReadData("Введите размер массива: ");          //Создаем переменную для первого введенного числа
int start = ReadData("Введите границы массива Начало: ");  //Создаем переменную для второго введенного числа
int stop = ReadData("Введите границы массива Конец: ");    //Создаем переменную для третьего введенного числа
int[] arrayLen = GenArray(array, start, stop);             //Переменная для хранения заполненного массива
PrintArray(arrayLen);                                      //Вызываем функцию для вывода результата
