﻿// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
// между ними в 2D пространстве.  
// A (3,6); B (2,1) -> 5,09  
// A (7,-5); B (1,-1) -> 7,21

Console.Clear();
Console.Write("Введите координаты точки А, Xa = ");
double Xa = int.Parse(Console.ReadLine());
Console.Write("Введите координаты точки А, Ya = ");
double Ya = int.Parse(Console.ReadLine());

Console.Write("Введите координаты точки А, Xb = ");
double Xb = int.Parse(Console.ReadLine());
Console.Write("Введите координаты точки А, Yb = ");
double Yb = int.Parse(Console.ReadLine());

double sqrab = ((Xb - Xa)*(Xb - Xa) + (Yb - Ya)*(Yb - Ya));
double result = Math.Sqrt(sqrab);
double result2 = Math.Round(result,2);

Console.Write($"расстояние между ними {result2}");
