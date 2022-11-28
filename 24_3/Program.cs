/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

int [] getRange(int length)
{
    int [] array = new int [length];
    Random numbers = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = numbers.Next(0,100);
    }
    return array;
}

void printArray( int [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

Console.ForegroundColor = ConsoleColor.DarkBlue;
int [] array = getRange(8);
printArray(array);
Console.ResetColor();