//============================================================================
// # 0 Напишите программу, которая на входи принимает число и выдает его кавадрат
//(число умноженное на само себя).
//============================================================================

string? inputLine = Console.ReadLine();
if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    int outNumber = inputNumber * inputNumber;
    //int outNumber = (int)Math.Pow(inputNumber,2);
    Console.WriteLine(outNumber);
}