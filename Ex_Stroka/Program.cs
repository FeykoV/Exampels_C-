﻿// Задание с дополнительной лекции по правилам написания кода
// работаем со строкой (разбиваем ее на отдельные элементы)

using System.Linq;

string text = "(1,2) (2,3) (4,5) (6,7)"
                    .Replace("(", "")
                    .Replace(")", "");

Console.WriteLine(text);

var data = text.Split(" ")
                    .Select(item => item.Split(','))
                    .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))
                    .Where(e => e.x % 2 == 0)
                    .Select(point => (point.x*10, point.y))
                    .ToArray();

for (int i = 0; i < data.Length; i++)
{
   // Console.WriteLine(data[i]); Это мы сначала работали с простым массивом
  /* for (int j = 0; j < data[i].Length; j++)
   {
        Console.WriteLine(data[i][j]);
   }*/                                 // тут мы поработали с массивом массивов
   Console.WriteLine(data[i]);
   Console.WriteLine();
}                    
