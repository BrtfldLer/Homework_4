// Задача 29: Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.
int [] array = new int[8];
int len = array.Length;
int index = 0;
while (index < len)
{
    array[index] = new Random().Next(-1000,1001);
    index++;
}
for (int i=0; i<len; i++)
{
Console.Write($" {array[i]} ");
}