//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет
Console.WriteLine("Введите день недели : ");
string dayWeek = Console.ReadLine();
switch (dayWeek) 
{
    
    case "1":
    Console.WriteLine("Понедельник -Нет");
    break;
   
    case "2":
    Console.WriteLine("Вторник  -Нет");
    break;

 case "3":
    Console.WriteLine("Среда -Нет");
    break;
    case "4":
    Console.WriteLine("Четверг -Нет");
    break;
    case "5":
    Console.WriteLine("Пятница -Нет");
    break;
    case "6":
    Console.WriteLine("Суббота -да");
    break;
    case "7":
    Console.WriteLine("Воскресенье -да ");
    break;
    default: 
    Console.WriteLine("Некорректный день недели");
    break;

}
if (dayWeek=="1")
{
    Console.WriteLine("Понедельник -Нет");
}
else if(dayWeek=="2")
{
   Console.WriteLine("Вторник  -Нет"); 
}
else if(dayWeek=="3")
{
   Console.WriteLine("Среда  -Нет"); 
}
else if(dayWeek=="4")
{
   Console.WriteLine("Четверг  -Нет"); 
}
   else if(dayWeek=="5")
{
   Console.WriteLine("Пятница  - нет"); 
}

else if(dayWeek=="6")
{
   Console.WriteLine("Суббота  - да"); 
}
else if(dayWeek=="7")
{
   Console.WriteLine("Воскресенье - да "); 
}
else 
{
   Console.WriteLine("Некорректный день недели");
}
