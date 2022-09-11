//==========================================================================
//                        Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 3D пространстве.
//==========================================================================

// Вариант 1
// int ReadData(string line)
// {
//     Console.Write(line);                                                                                        //Выводим сообщение
//     int number = int.Parse(Console.ReadLine() ?? "0");                                                          //Считываем строковое число и преобразуем в знаковое целое число
//     return number;                                                                                              //Возвращаем значение
// }

// double CalculateDistance(int x1, int y1, int z1, int x2, int y2, int z2)
// {
//     double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));      //Производим вычисления
//     return distance;                                                                                            //Возвращаем значение
// }

// void PrintResult(string line)
// {
//     Console.WriteLine(line);                                                                                    //Выводим результат в консоль
// }

// int x1 = ReadData("Введите координату X первой точки: ");                                                       //Создаем переменные для преобразованных чисел
// int y1 = ReadData("Введите координату Y первой точки: ");
// int z1 = ReadData("Введите координату Z первой точки: ");
// int x2 = ReadData("Введите координату X второй точки: ");
// int y2 = ReadData("Введите координату Y второй точки: ");
// int z2 = ReadData("Введите координату Z второй точки: ");

// double result = CalculateDistance(x1, y1, z1, x2, y2, z2);                                                      //Создаем переменную для хранения результата вычисления
// PrintResult("Расстояние между точками: " + Math.Round(result, 2));                                              //Вызываем функцию для вывода результата

//Вариант 2
//=========================================================================================================================================================================================
string ReadData(string inpNumber)
{
    Console.Write(inpNumber);                                                                                 //Выводим сообщение
    string number = Console.ReadLine() ?? "";                                                                 //Считываем строковое число
    return number;                                                                                            //Возвращаем значение
}



int[] ParseNumbers(string numbers)
{
    numbers = numbers.Replace("x(", "");                                                                       //Удаляем лишние знаки
    numbers = numbers.Replace(");y(", ",");                                                                    //Заменяем лишние знаки на ","
    numbers = numbers.Replace(")", "");                                                                        //Удаляем лишние знаки
    string[] line = numbers.Split(",");                                                                        //Собираем массив и удаляем знаки
    int[] array = Array.ConvertAll(line, int.Parse);                                                           //Конвертируем строковый массив в числовой
    return array;                                                                                              //Возвращаем значение
}

double CalculateDistance(int[] num)
{
    int x1 = (num[0]);                                                                                         //Присваиваем переменной индекс числа в массиве
    int y1 = (num[1]);
    int z1 = (num[2]);
    int x2 = (num[3]);
    int y2 = (num[4]);
    int z2 = (num[5]);

    double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));      //Производим вычисления
    return distance;                                                                                            //Возвращаем значение
}

void PrintResult(string line)
{
    Console.WriteLine(line);                                                                                    //Выводим результат в консоль
}


string numbers = ReadData("Введите координаты в формате x(5,4,3);y(5,2,1): ");                                  //Создаем переменную для введенных данных
int[] num = ParseNumbers(numbers);                                                                              //Создаем переменную для хранения числового массива
double result = CalculateDistance(num);                                                                         //Создаем переменную для хранения результата вычисления
PrintResult("Расстояние между точками: " + Math.Round(result, 2));                                              //Вызываем функцию для вывода результата

