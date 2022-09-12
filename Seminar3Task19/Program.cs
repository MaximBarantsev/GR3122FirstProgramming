//==========================================================================
//                        Задача 19
// Напишите программу, которая принимает на вход пятизначное число и
// проверяет, является ли оно палиндромом.
//==========================================================================
// Для любой длины
// int ReadData(string line)
// {

//     Console.WriteLine(line);                               //Выводим сообщение
//     int numbers = int.Parse(Console.ReadLine() ?? "0");    //Считываем строковое число и преобразуем в знаковое целое число
//     return numbers;                                        //Возвращаем значение
// }


// string testPalindrom(int num)
// {

//     char[] charArray = num.ToString().ToCharArray();      //Преобразуем число в массив символов
//     int index = 0;                                        //Задаем переменную для цикла
//     while (index < charArray.Length)                      //Задаем цикл
//     {
//         int k = charArray[0];                             //Задаем переменную для цикла
//         int j = charArray[^1];                            //Задаем переменную для цикла
//         if (k == j)                                       //Сравниваем два значения
//         {
//             k++;                                          //Увеличение переменной на 1
//             j++;                                          //Увеличение переменной на 1
//         }
//         else
//         {
//             return "Не палиндром.";                       //Возвращаем отрицательный результат
//         }
//         index++;                                          //Увеличение переменной на 1
//     }
//     return "Палиндром.";                                  //Возвращаем положительный результат


// }

// void PrintResult(string line)
// {
//     Console.WriteLine(line);                              //Выводим результат в консоль
// }


// int num = ReadData("Введите число: ");                    //Создаем переменную для преобразованного числа
// PrintResult(testPalindrom(num));                          //Вызываем функцию для вывода результата



//Вариант через словарь для 5 значного числа
int ReadData(string line)
{

    Console.WriteLine(line);                                                             //Выводим сообщение
    int numbers = int.Parse(Console.ReadLine() ?? "0");                                  //Считываем строковое число и преобразуем в знаковое целое число
    return numbers;                                                                      //Возвращаем значение
}


Dictionary<int, int> GenerationDicPoli()
{
    Dictionary<int, int> palindrom = new Dictionary<int, int>();                         //Создаем словарь

    for (int i = 10; i < 100; i++)                                                       //Цикл для заполнения словаря
    {
        int polin = (i) * 100 + (i % 10) * 10 + i / 10;                                  //Вычисляем палиндромы
        palindrom.Add(polin, 0);                                                         //Заполняем словарь
        Console.WriteLine(polin);                                                        //Выводим палиндромы в консоль
    }
    return palindrom;                                                                    //Возвращаем значение
}

bool TestPolinHash(int num, Dictionary<int, int> dict)
{
    int x = num / 1000;                                                                  //Отсеиваем первые две цифры числа
    int y = num % 100;                                                                   //Отсеиваем последние две цифры числа
    int number = x * 100 + y;                                                            //Объединяем эти два числа
    if (dict.ContainsKey(number))                                                        //Сравнием получинное число со словарем
    {
        return true;                                                                     //Возвращаем положительный результат
    }
    else
    {
        return false;                                                                    //Возвращаем отрицательный результат
    }
}

void PrintResult(string line)
{
    Console.WriteLine(line);                                                             //Выводим результат в консоль
}


int palindrom = ReadData("Введите число: ");                                             //Создаем переменную для полученного числа
Dictionary<int, int> palindromDic = GenerationDicPoli();                                 //Создаем переменную для словаря
PrintResult(TestPolinHash(palindrom, palindromDic) ? "Палиндром" : "Не палиндром");      //Вызываем функцию для вывода результата с использование тернарного оператора