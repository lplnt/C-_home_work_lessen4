// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Clear(); //очистка консоли
Console.Write("Введите число которое будете возводить в стерень: "); //вывод сообщение 
int num1 = Convert.ToInt32(Console.ReadLine()); //ввод числа
Console.Write("Введите число степени в которую будете возводить: "); //вывод сообщение 
int num2 = Convert.ToInt32(Console.ReadLine()); //ввод числа

Console.WriteLine($"{Math.Pow((num1),num2)}");




