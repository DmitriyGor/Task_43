/*
Задача 43: 
Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double firstNumber = 0;
double secondNumber = 0;
double thirdNumber = 0;
double fourNumber = 0;
Console.Write("Введите значение B1:  ");
firstNumber = Convert.ToDouble(Console.ReadLine()); // Convert.ToInt32 == int.Parse

Console.Write("Введите значение K1:  ");
secondNumber = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение B2:  ");
thirdNumber = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение K2:  ");
fourNumber = Convert.ToDouble(Console.ReadLine());
// x = (b2 - b1) / (k1 - k2)
// y = ((b2 - b1) / (k1 - k2)) * k1 + b1
double x =Math.Round((thirdNumber - firstNumber) / (secondNumber - fourNumber),2);
double y = Math.Round(((thirdNumber - firstNumber) / (secondNumber - fourNumber)) * secondNumber + firstNumber,2);
Console.Write($"Пересечение в точке : ({x} ; {y})");