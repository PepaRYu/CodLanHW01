﻿/*
##############################################################################################################################################################################################
 Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какоге число больше, какое меньше.
 ##############################################################################################################################################################################################
*/
using System;
Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber != secondNumber)
{
    if (firstNumber > secondNumber)
    {
        Console.WriteLine("Большее число " + firstNumber);
    }
    if (secondNumber > firstNumber)
    {
        Console.WriteLine("Большее число " + secondNumber);
    }
}
else
{
    Console.WriteLine("Числа равны!");
}

/*
##############################################################################################################################################################################################
 Задача 4: Напишите программу, которая на вход принимает два числа и выдаёт, какоге число больше, какое меньше.
 ##############################################################################################################################################################################################
*/



