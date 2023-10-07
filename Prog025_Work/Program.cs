// Напишите программу, которая принимает на вход число (N) и
//  выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// Console.WriteLine("Введите число");
// int num= Convert.ToInt32(Console.ReadLine());

// int i = 1;

//  while(i<=num)
//  {
//     Console.WriteLine(Math.Pow(i,2));
//     i=i+1;
//  }



Console.WriteLine("Введите число");
int num= Convert.ToInt32(Console.ReadLine());

for(int i = 1; i<=num; i++)
{
    Console.WriteLine(Math.Pow(i,2));
}
