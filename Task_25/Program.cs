// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
Console.WriteLine("Введите число A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int B = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int newA = 1;
for (int i = 1; i <= B; i++)
{
    newA *=A;
}
Console.WriteLine($"Число {A} в натуральной степени {B} равно {newA}");