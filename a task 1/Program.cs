//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Enterb number: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num > 99 && num <1000)
{
    int secondNumber = (num / 10) % 10; //895/10 = 85%10=9
    Console.WriteLine($"вторая цифра в числе {num} = > {secondNumber}");
}
else
Console.WriteLine($"Число {num} не трехзначное");
