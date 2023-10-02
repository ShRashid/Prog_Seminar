// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
//возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите число");
// int a= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число");
// int b= Convert.ToInt32(Console.ReadLine());

// int GetSumNum()
// {

//     int i = 1;
//     int result = a;

//     while(i<b)
//     {
//         result= result * a;
//         i++;
//     }

//     return result;
// }


// System.Console.WriteLine(GetSumNum());

// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Введите число");
// string a = Console.ReadLine();
// int sum = 0;

// for (int i = 0; i < a.Length; i++)
// {
//     sum += int.Parse(a[i].ToString());
// } 

// Console.WriteLine("Сумма цифр числа: " + a + " = " + sum);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

//Ввод числа с экрана
int Prompt(string message)
{
    Console.Write(message); //Вводим приглашение ко вводу
    string ReadInput = Console.ReadLine(); //Считываем с клавиатуры
    int result = int.Parse(ReadInput); //Преобразовываем в число
    return result; //Возвращаем результат
}

//Метод для получения случайных значенией массива
int[] GenerateArray(int Length, int minValue, int maxValue)
{
    int[] array = new int[Length]; //Создаём массив
    Random random = new Random(); //Создаём объект для генерации случайных значений
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1); //Генерируем случайное значение
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", "); //Выводим элементы массива
    }
    Console.WriteLine(array[array.Length - 1] + "]"); //Выводим последний элемент массива    
}

int length = Prompt("Введите длинну массива: "); //Вводим длинну массива
int min = Prompt("Начальное значение, для диапазона случайных чисел: "); //Вводим начальное значение
int max = Prompt("Конечное значение, для диапазона случайных чисел: ");
int[] array = GenerateArray(length, min, max); //Генерируем массив случайных значений
PrintArray(array);
