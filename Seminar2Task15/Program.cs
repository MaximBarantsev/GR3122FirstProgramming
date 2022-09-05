//==========================================================================
//                        Задача 15
// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
//==========================================================================

Console.WriteLine("Введите число: ");                      //Комментарий ко вводу
string inputLine = Console.ReadLine()??"";                 //Вводим число
int inputDayOfWeek = int.Parse(inputLine);                 //Преобразуем строковое представление числа в знаковое целое число

string outDayOfWeek = string.Empty;                        //Временная переменная

//Вариант 1
outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.                       //Запрашиваем день недели из системы.
GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(inputDayOfWeek)); 

Console.WriteLine(inputDayOfWeek == 6 || inputDayOfWeek == 0 ? ("Это выходной день") : ("Рабочий день"));     //Вывод результата в консоль через тернарный оператор

// //Вариант 2
// switch(inputDayOfWeek)                                                                                     //Используем конструкцию switch-case.
//        {
//         case 1: outDayOfWeek="Понедельник"; break;
//         case 2: outDayOfWeek="Вторник"; break;
//         case 3: outDayOfWeek="Среда"; break;
//         case 4: outDayOfWeek="Четверг"; break;
//         case 5: outDayOfWeek="Пятница"; break;
//         case 6: outDayOfWeek="Суббота"; break;
//         case 7: outDayOfWeek="Воскресенье"; break;
//        }

// Console.WriteLine(inputDayOfWeek == 6 || inputDayOfWeek == 7 ? ("Это выходной день") : ("Рабочий день"));  //Вывод результата в консоль через тернарный оператор