//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Enterb number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введте число: ");
int index = Convert.ToInt32(Console.ReadLine());

double pow = Math.Pow(10, index);
Console.Clear();

if(num < pow)
{
    Console.WriteLine($"В числе {num} нет третьей цифры" );
   
}

else
{
    int tmp = num;

while (tmp > pow )
{
    tmp/=10;
}
int result = tmp % 10;
Console.WriteLine($"Цифра под индексом {index} числа {num} ->{result} ");
}
