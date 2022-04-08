// Задача 27: Напишите программу, которая принимает на 
// вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int i = 0;
int count = 0;
int NewNumber = number;
while (NewNumber >= 1)
{
    i = NewNumber%10;
    count = count + i;
    NewNumber = NewNumber/10;
}
Console.WriteLine($"Сумма цифр числа {number} равна {count}");