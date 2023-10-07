// Задача 31: Задайте массив из 12 элементов, заполненный
//  случайными числами из промежутка [-9, 9]. Найдите сумму 
//  отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
//  положительных чисел равна 29, сумма отрицательных равна -20.

// int[] array = new int[12];

// int sumNum=0;
// int sumNegNum=0;

// for (int i = 0; i < array.Length; i++)
// {
//   array[i]= new Random().Next(-9,10);
//   System.Console.Write(array[i]+ " ");

//   if(array[i]>0)
//   {
//     sumNum=sumNum+ array[i];
//   }
//   else
//   {
//     sumNegNum= sumNegNum +array[i];
//   }
// }
// System.Console.WriteLine();
// System.Console.WriteLine("Сумма полож.= "+ sumNum+ " отриц. = "+ sumNegNum);

// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

// int[] array = new int[] {3,-21,9,-2};

// for (int i = 0; i < array.Length; i++)
// {
//   array[i]= array[i] *-1;
//   System.Console.Write(array[i]+ " ");
// }

// Задача 33: Задайте массив. Напишите программу, которая определяет,
//  присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// int[] array = new int[6];

// Console.WriteLine("Введите число");
// int num = int.Parse(Console.ReadLine());

// bool isFind= false;

// for (int i = 0; i < array.Length; i++)
// {
//   array[i]= new Random().Next(-1,3);
//   System.Console.Write(array[i]+ " ");

//   if(array[i]== num)
//   {
//     isFind=true;
//   }
 
// }

// if(isFind)
//   {
//     Console.Write("Да");
//   }
//   else
//   {
//     Console.Write("Нет");
//   }

// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат 
// в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении 
// сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// int[] array = new int[123];

// int count=0;

// for (int i = 0; i < array.Length; i++)
// {
//   array[i]= new Random().Next(-1,150);
//   System.Console.Write(array[i]+ " ");

//   if(array[i]>9 && array[i]<100)
//   {
//     count++;
//  // count=count+1;
//   }
// }
// System.Console.WriteLine("Количество = "+ count);

// Задача 37: Найдите произведение пар чисел в одномерном массиве.
//  Парой считаем первый и последний элемент, второй и предпоследний
//   и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] array = new int[5];
int countElErray1= array.Length;
int[] array2 = new int[countElErray1/2 + countElErray1%2];

for (int i = 0; i < array.Length; i++)
{
  array[i]= new Random().Next(-1,10);
  System.Console.Write(array[i]+ " ");
}

System.Console.WriteLine();

for (int i = 0; i < array2.Length; i++)
{
  if(i == countElErray1-1-i)
  {
      array2[i]= array[i];
      System.Console.Write(array2[i]+ " ");
      break;
  }

  array2[i]= array[i] * array[countElErray1-1-i];
  System.Console.Write(array2[i]+ " ");
  
}