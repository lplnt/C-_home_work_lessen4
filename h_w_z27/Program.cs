// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Clear(); //очистка консоли
Console.Write("Введите число которое сумму которого будете считать: "); //вывод сообщение 
int num = Convert.ToInt32(Console.ReadLine()); //ввод числа
int suma = 0; 
while (num > 0)
{
    int digit = num % 10;
    suma = suma + digit;
    num = num / 10;
}

Console.WriteLine(suma);