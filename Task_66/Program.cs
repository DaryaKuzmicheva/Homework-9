/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/


Console.WriteLine("Введите число n");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число m");
int m = Convert.ToInt32(Console.ReadLine());
int result = 0;

if(n<m)
  HappyNewYear(n);
else
  Console.Write("Невозможно выполнить действие");

void HappyNewYear(int n)
	{
      if(n == m+1)
			  Console.Write($"{result}");
      else
        {
        result = result + n;
        n = n + 1;
			  HappyNewYear(n);
        }
    }