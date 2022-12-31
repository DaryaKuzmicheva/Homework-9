/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/


Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
NaturalNumber(n);
void NaturalNumber(int n)
		{
      if(n == 1)
			Console.Write("1");
      else
      {
      Console.Write($"{n}, ");
      n = n -1;
			NaturalNumber(n);
      }  		  
		}
