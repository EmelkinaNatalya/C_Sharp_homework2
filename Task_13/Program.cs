// Задача 13: Напишите программу, которая выводит третью 
// цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());


if (N<1000 && N>99)
{
Console.Write(N = N%10); 
}
else if (N>999)
{
    while (N>999)
    {
        N = N/10;  
    }
    Console.Write(N = N%10); 
}
else 
{
Console.Write("У введённого числа нет 3 цифры");
}