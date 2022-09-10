//==========================================================================
//                        Задача 23
// Напишите программу, которая принимает на вход число (N) и
// выдаёт таблицу кубов чисел от 1 до N.
//==========================================================================

int ReadData(string line)
{
    Console.Write(line);// Выводим сообщение
    int number = int.Parse(Console.ReadLine() ?? "0");         //Считываем строковое число и преобразуем в знаковое целое число
    return number;                                             //Возвращаем значение
}

//
string lineNumbers(int numberN, int pow)
{
    int i = 1;                                                 //Задаем переменную для цикла
    string outLine = string.Empty;                             //Задаем пустую переменную для хранения результата
    while (i < numberN)//Задаем цикл
    {
        outLine = outLine + Math.Pow(i, pow) + "\t";           //Производим вычисления внутри цикла
        ++i;                                                   //Увеличение переменной на 1
    }
    outLine = outLine + Math.Pow(numberN, pow);                //Производим вычисления по окончанию цикла
    return outLine;                                            //Возвращаем значение
}


void PrintResult(string line)
{
    Console.WriteLine(line);                                   //Выводим результат в консоль
}

int num = ReadData("Введите число N: ");                       //Создаем переменную для преобразованного числа


PrintResult(lineNumbers(num, 1));                              //Вызываем функцию для вывода результата
PrintResult(lineNumbers(num, 3));                              //Вызываем функцию для вывода результата