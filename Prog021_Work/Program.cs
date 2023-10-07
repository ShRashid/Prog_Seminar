// Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21


// int n =49;
// double result= Math.Sqrt(48);

// double res= Math.Pow(-3,3);
// System.Console.WriteLine(res);

Console.WriteLine("Введите число");
int x1= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int y1= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int x2= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int y2= Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(x1-x2,2)+ Math.Pow(y1-y2,2));

Console.WriteLine(d);