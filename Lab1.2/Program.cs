using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Вариант 9

namespace Lab1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int N = 10;
            int[,] array = new int[N, N];
            Random random = new Random();
            for (int i = 0; i < 10; i++) 
            {
                for (int j = 0; j < 10; j++) 
                {
                    array[i, j] = random.Next(-100, 100);
                }
            }
            WriteArr(array);
            FirstPart(array);
            SecondPart(array);
            Console.ReadKey();
        }
        //Подсчитать количество локальных минимумов заданной матрицы размером 10 на 10
   
        static void FirstPart(int[,] array) {
            int count = 0;
            for (int i = 1; i < 9; i++) {
                for (int j = 1; j < 9; j++) {
                    if ((array[i, j] < array[i - 1, j]) && (array[i, j] < array[i + 1, j]) && (array[i, j] < array[i, j - 1])&& (array[i, j] < array[i, j + 1])) {
                        count += 1;
                    }
                }
            }
           
            Console.WriteLine("Локальных минимумов: "+ count);
        }

        //Найти сумму модулей элементов, расположенных выше главной диагонали.
        static void SecondPart(int[,] array)
        {
            int sum = 0;
            for (int i = 0; i < 10; i++) {
                for (int j = i + 1; j < 10; j++) {
                    sum += Math.Abs(array[i, j]);
                }
            }
            
            Console.WriteLine("Сумма элементов верхней диагонали: " + sum);
        }

        static void WriteArr(int[,] array) {
            for (int i = 0; i < 10; i++) {
                for (int j = 0; j < 10; j++) {
                    Console.Write($"{array[i, j],4}");                
                }
                Console.WriteLine();
            }
        
        }
    }
}
