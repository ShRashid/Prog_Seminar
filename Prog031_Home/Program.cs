// Разница между максимальным и минимальным элементами массива
// Инструкция по использованию платформы
// Напишите программу для работы с массивом вещественных чисел.
// Реализуйте класс ArrayOperations, который содержит следующие статические
//  методы:
// FindMax(double[] array): Метод принимает на вход массив вещественных 
// чисел array и возвращает максимальное число из массива.
// FindMin(double[] array): Метод принимает на вход массив вещественных 
// чисел array и возвращает минимальное число из массива.
// CalcDifferenceBetweenMaxMin(double[] array): Метод принимает на вход
// массив вещественных чисел array и возвращает разницу между
// максимальным и минимальным числами в массиве.
// PrintArray(double[] array): Метод для вывода массива на экран.
// Он принимает на вход массив array и выводит его элементы с двумя 
// знаками после запятой через табуляцию.
// Аргументы, передаваемые в метод/функцию:

// '3.17, 8.94, 2.36, 5.72, 0.85'
// На выходе:
// Массив:
// 3.17    8.94    2.36    5.72    0.85    
// Разность между максимальным и минимальным элементом = 8.09

using System;

public class Answer
{
    public static double FindMax(double[] array)
    {     // Введите свое решение ниже
       if (array == null) throw new ArgumentNullException(nameof(array));
       if (array.Length == 0) return 0;
       double maxValue = array[0];
          for (int i = 1; i < array.Length; i++)
          {
            if (maxValue < array[i]) maxValue = array[i];
          }
        return maxValue;          
    }

    public static double FindMin(double[] array)
    {     // Введите свое решение ниже
        if (array == null) throw new ArgumentNullException(nameof(array));
        if (array.Length == 0) return 0;

        double minValue = array[0];

        for(int i = 1; i < array.Length; i++)
        {
            if(minValue > array[i]) minValue = array[i];
        }
        return minValue;
    }

    public static double CalcDifferenceBetweenMaxMin(double[] array)
    {// Введите свое решение ниже

        return Math.Abs(FindMax(array) - FindMin(array));

    }

    public static void PrintArray(double[] array)
    {// Введите свое решение ниже
        foreach (var item in array)
        {
            Console.Write("{0:F2}", item);
            Console.Write("\t");
        }

        Console.WriteLine();
    }
 // Не удаляйте и не меняйте метод Main! 


    public static void Main(string[] args)
    {
        double[] array;
        if (args.Length == 0)
        {
            array = new double[] { 3, 7.4, 22.3, 2, 78 };
        }
        else
        {
            // Иначе, парсим аргументы в массив чисел
            string[] argStrings = args[0].Split(", ");
            array = new double[argStrings.Length];
            for (int i = 0; i < argStrings.Length; i++)
            {
                if (double.TryParse(argStrings[i], out double number))
                {
                    array[i] = number;
                }
                else
                {
                    Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
                    return;
                }
            }
        }

        Console.WriteLine("Массив:");
        PrintArray(array);
        double diff = CalcDifferenceBetweenMaxMin(array);
        Console.WriteLine($"Разность между максимальным и минимальным элементом = {diff:f2}");
    }
}