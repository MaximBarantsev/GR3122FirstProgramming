// ---------------------------------------------------------------------
//                                 Задача 27
// Напишите программу, которая принимает на вход число и выдаёт
// сумму цифр в числе.
// ---------------------------------------------------------------------

int ReadData(string line)
{

    Console.WriteLine(line);                           //Выводим сообщение
    int number = int.Parse(Console.ReadLine() ?? "0"); //Считываем и преобразуем число
    return number;                                     //Возвращаем значение
}

//Вариант 1
int SumDigit(int num)
{
    int sum = 0;                                       //Временная переменная для накопления результата
    while (num > 0)                                    //Запускаем цикл
    {
        sum += num % 10;                               //Остаток от деления складываем с переменной
        num = num / 10;                                //Делим введенное число, для продолжения и остановки цикла
    }
    return sum;                                        //Возвращаем значение
}

//Вариант 2
int SumNumbers(int num)
{
    int sum = 0;
    char[] inpNum = num.ToString().ToCharArray();

    for (int i = 0; i < inpNum.Length; i++)
    {
        sum += int.Parse(inpNum[i].ToString());
    }
    return sum;
}

void PrintResult(string line)
{
    Console.WriteLine(line);                           //Печатаем результат
}

int numbers = ReadData("Введите число: ");             //Создаем переменную для введенного числа


DateTime d1 = DateTime.Now;                            //Переменная старта отсчета
int res = SumDigit(numbers);                           //Создаем переменную для результата
Console.Write("Время операции: ");                     //Печатаем комментарий
Console.WriteLine(DateTime.Now - d1);
DateTime d2 = DateTime.Now;                            //Переменная старта отсчета
int result = SumNumbers(numbers);                      //Создаем переменную для результата
Console.Write("Время операции: ");                     //Печатаем комментарий
Console.WriteLine(DateTime.Now - d2);                  //Печатаем результат затраченного времени                 
PrintResult("Сумма цифр в числе равна: " + res);       //Вызываем функцию для вывода результата
PrintResult("Сумма цифр в числе равна: " + result);    //Вызываем функцию для вывода результата











