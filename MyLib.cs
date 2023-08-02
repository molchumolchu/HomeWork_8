using System;

namespace MyLibrary
{
    public static class MyLibraryClass
    {
        public static int Input(string text)
        {
            Console.WriteLine(text);
            return Convert.ToInt32(Console.ReadLine());
        }
        
        public static void FillArrayMinMax(int [] numbers, int minValue, int maxValue)//метод заполнения массива
        {
            maxValue++;
            Random rnd = new Random();
            for (int i=0; i<numbers.Length; i++)
            {
                numbers[i]= rnd.Next(minValue, maxValue);
            }               
        }
        
        public static void PrintArrayMinMax(int [] numbers) // печать
            {
                for (int i=0; i<numbers.Length; i++)
                {
                    Console.Write($"{numbers[i]} ");
                }
                Console.WriteLine();
            }
        
        public static void FillArrayMassivMinMax(int[,] matrix, int minValue = -9, int maxValue = 9)
            {

                Random random = new Random();
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = random.Next(minValue, maxValue);
                    }
                }
            }

        public static void PrintArrayMassiv(int[,] matrix)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write($"{matrix[i, j]}\t "); //табуляция
                    }
                    Console.WriteLine();
                }
            }
    }
}
