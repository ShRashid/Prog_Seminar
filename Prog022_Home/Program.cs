// Внутри класса Answer напишите метод IsPalindrome, который принимает на вход пятизначное число number и проверяет, является ли оно палиндромом.
// Метод должен проверить является ли число пятизначным, в противном случае - вывести Число не пятизначное и False в следующей строке.
// Для остальных чисел вернуть True или False.
// 14212 -> False
// 12821 -> True
// 234322 -> Число не пятизначное
//                      False
using System;

public class Answer
{
    static bool IsPalindrome(int number){
      // Введите свое решение ниже
    string numberString = number.ToString();  
    bool isPalindrome = true; 

    if (numberString.Length != 5 ) 
    {
      System.Console.WriteLine("Число не пятизначное");
      isPalindrome = false;  
      return isPalindrome;
    }
 
    for (int i = 0; i < numberString.Length / 2; i++)  
    {  
        if (numberString[i] != numberString[numberString.Length - 1 - i])  
        {  
            isPalindrome = false;  
            break;  
        }  
    }  
    return isPalindrome; 
 
    }
  
  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            //number = 64546;
            number = 645464;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}