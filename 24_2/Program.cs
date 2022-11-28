/* Задача 27: Напишите программу, которая принимает на вход число
 и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */


Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.Write("Введите число: ");
int UserNumber = Convert.ToInt32(Console.ReadLine());
Console.ResetColor();
int sumDigit(int UserNumber)
  {
    int counter = Convert.ToString(UserNumber).Length;
    int sumDigit = 0;
    int result = 0;
    for (int i = 0; i < counter; i++)
    {
      sumDigit = UserNumber - UserNumber % 10;
      result = result + (UserNumber - sumDigit);
      UserNumber = UserNumber / 10;
    }
    return result;
  }  
int SumDigit = sumDigit(UserNumber);
Console.WriteLine($"Сумма цифр в числе {UserNumber} = " + SumDigit);
