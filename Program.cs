using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maksimumes
{
    class Program
    {
        static void Main()
        {
            string[] str2 = Console.ReadLine().Split();
            int N = int.Parse(str2[0]);
            int M = int.Parse(str2[1]);
            matrik(N, M);
        }
            static void matrik(int row, int column)
            {
               /*Дана матрица целых чисел размером  N×M (N, M от 1 до 10). 
                Найти максимум в каждом столбце матрицы. Значения вывести в строчку через пробел.

                Начальные данные: на первой строчке вводится количество строк N и количество столбцов M через пробел. Далее вводятся N строк по M значений элементов матрицы через пробел.
                Вывод результата: M чисел через пробел.*/

                int max1 = 0;
                int[,] numbers = new int [row, column];
                for (int i = 0; i < row; i++)
                {
                    string[] str1 = Console.ReadLine().Split();
                    for (int j = 0; j < column; j++)
                        numbers[i, j] = int.Parse(str1[j]);
                }
                    
                for (int i = 0; i < column; i++)
                {
                    max1 = numbers[0, i]; 
                    for (int j = 1; j <row; j ++)
                        max1 = maximum(numbers[j, i], max1);
                    Console.Write(max1);
                    if (i != column - 1) Console.Write(" ");
                }
                Console.WriteLine();
            }

            static int maximum(int num, int max)
            {
                if (max < num) max = num;
                return max;
            }
        }
}
   
