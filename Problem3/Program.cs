// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и 
// проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Введите номер дня недели");
int day = Convert.ToInt32(System.Console.ReadLine());
if (day > 7)
System.Console.WriteLine("Некорректный номер");
if (day < 6)
{
    System.Console.WriteLine("Нет");
}
else
{
    System.Console.WriteLine("Да");
}