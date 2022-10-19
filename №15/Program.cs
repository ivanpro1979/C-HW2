// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели,
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.Clear();
Console.WriteLine("Программа определения выходной день или нет по номеру дня недели");
Console.Write("Введите порядковый номер дня недели: ");
int a = (Convert.ToInt32(Console.ReadLine()));
if (a < 1 || a > 7)
{
    Console.WriteLine("Неделя содержит 7 дней, введите цифру от 1 до 7");
}
else
{
    if (a == 1)
    {
        Console.WriteLine("нет - Понедельник не выходной день");
    }
    else if (a == 2){
        Console.WriteLine("нет - Вторник не выходной день");
    }
    else if (a == 3){
        Console.WriteLine("нет - Среда не выходной день");
    }
    else if (a == 4){
        Console.WriteLine("нет - Четверг не выходной день");
    }
    else if (a == 5){
        Console.WriteLine("нет - Пятница не выходной день");
    }
    else if (a == 6){
        Console.WriteLine("да - Суббота выходной день");
    }
    else if (a == 7){
        Console.WriteLine("да - Воскресенье выходной день");
    }
}