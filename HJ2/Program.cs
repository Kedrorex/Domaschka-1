// Задача 4: Напишите программу, которая принимает на 
//вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите сравниваемые числа: ");

int n = 3;
int [] number = new int[n];
int max = number[0];

for (int i = 0; i < n; i++)
{
   number[i] = Convert.ToInt32(Console.ReadLine());

   if(number[i] > max) max = number[i];
};

Console.WriteLine($"{max}");

//

