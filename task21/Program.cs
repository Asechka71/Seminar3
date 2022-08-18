/*
Задача 21
Напишите программу, которая принимает на вход 
координаты двух точек и находит расстояние между ними в 3D пространстве.
*/

Console.WriteLine("Введите координаты первой точки через запятую ");

int[] firstPosition = Array.ConvertAll<string,int>
(Console.ReadLine().Split(','), elem => { return System.Convert.ToInt32 (elem);});

Console.WriteLine("Введите координаты второй точки через запятую ");

int[] secondPosition = Array.ConvertAll<string,int>
(Console.ReadLine().Split(','), elem => { return System.Convert.ToInt32 (elem);});

double formula = Math.Sqrt
(
 (secondPosition[0] - firstPosition[0]) * (secondPosition[0] - firstPosition[0]) +
 (secondPosition[1] - firstPosition[1]) * (secondPosition[1] - firstPosition[1]) +
 (secondPosition[2] - firstPosition[2]) * (secondPosition[2] - firstPosition[2])
);
Console.WriteLine(Math.Round(formula,2));