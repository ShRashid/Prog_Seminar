// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите день недели: ");
int nDay = Convert.ToInt32(Console.ReadLine());

if (nDay > 0 && nDay <= 5) 
{
    Console.WriteLine("Нет");
}
else if (nDay > 5 && nDay < 8)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Число не соответствует дню недели");
}

