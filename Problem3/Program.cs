// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и 
// проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

bool DayOff(int arg)
{
    if (arg < 6)
    {
        return false;}
    else
    {
        return true;
    }
}


System.Console.WriteLine("Введите номер дня недели");
int day = Convert.ToInt32(System.Console.ReadLine());
if (day > 7)
{
    System.Console.WriteLine("Некорректный номер");
}
else
{
    System.Console.WriteLine(DayOff(day));
}