﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Сделать в функции, сделать проверку на отрицательность.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

/*
Console.WriteLine("Введите первое число");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число (натуральное)");
int B = int.Parse(Console.ReadLine());
if(B <= 0)
{
    Console.WriteLine("Вы ввели не натуральное число");
}
else
{

int Pow = A;
for(int i = 1; i < B; i++)
 {
   Pow = Pow * A;
 }


Console.WriteLine($"{A} в степени {B} равно  " + Pow);
}
*/


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

/*
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());
int sum = 0;
int N1 = N;
while(N1 > 0)
{
   sum = sum + N1 % 10;
   N1 = N1 / 10;
}
Console.WriteLine($"Сумма цифр в числе {N}  равна   " + sum);
*/


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Элементы задаются рандомно (диапазон выбрать самостоятельно) Итоговый массив должен содержать в себе суммы цифр числа. Т.е. необходимо подсчитывать суммы цифр каждого числа и записывать их в новый массив.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 10]
// 63, 12, 33, 36 -> [9, 3, 6, 9]

    Console.Write("Введите размер массива: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
        Console.Write(array[i] + " ");
    }