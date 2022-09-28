// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Clear(); //очистка консоли

int[] array = new int[8];
Random rnd = new Random();
for(int i = 0; i < array.Length; i++ )
{
    array[i] = rnd.Next(0,10);
    Console.Write(array[i]+" ");

}
