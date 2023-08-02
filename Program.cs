using System;
using MyLibrary;


namespace NAME
{
    class Program
    {
        static void Main(string[] args)
        {
            void Task54()
            // Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
            {
                int rows = 4;
                int columns = 4;
                int[,]matrix = new int[rows,columns];
                MyLibraryClass.FillArrayMassivMinMax(matrix, 0, 10);
                MyLibraryClass.PrintArrayMassiv(matrix);

                for (int i=0; i< rows; i++)
                {
                    for (int j=0; j<columns; j++)
                    {
                        for (int k=0; k<columns-j-1; k++)
                        {
                            if (matrix[i,k]<matrix[i, k+1])
                            {
                                (matrix[i,k], matrix[i,k+1]) = (matrix[i,k+1], matrix[i,k]);
                            }
                        }
                    }
                }
                
                Console.WriteLine();
                MyLibraryClass.PrintArrayMassiv(matrix);

            }

            
            void Task56()
            // Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
            {
                int rows = 4;
                int columns = 4;
                int[,]matrix = new int[rows,columns];
                MyLibraryClass.FillArrayMassivMinMax(matrix, 0, 10);
                MyLibraryClass.PrintArrayMassiv(matrix);

                int minSum=0;
                int indexRow=0;

                for (int i=0; i< rows; i++)
                {
                    int sum = 0;
                    for (int j=0; j<columns; j++)
                    {
                        sum += matrix [i,j];
                    }
                    if (minSum<sum) 
                    {
                        minSum=sum;
                        indexRow=i;
                    }                    
                }
                Console.WriteLine($"Сумма чисел строки {indexRow+1} равна {minSum}");
            }
            
            
            void Task58()
            {
                // int size = 16;
                // int[] d= new int [size];
                // for (int i=0; i<size; i++)
                // {
                //     d[i]=i+1;
                // }
                // MyLibraryClass.PrintArrayMinMax(d);

                int rows = 4;
                int columns = 4;
                int [,] matrix = new int [rows,columns];

                int i=0;
                int j=0;

                int delta_i=0;
                int delta_j=1;

                int steps = columns;
                int turns =0;

                for (int k=0; k<matrix.Length; k++)
                {
                    matrix[i,j]=k+1;
                    steps --;
                    // Console.Write($"{matrix[i,j]} ({i}, {j}) ");
                    
                    if (steps ==0)
                    {
                        steps= rows -1-turns/2;
                        turns++;
                        int temp = - delta_i;
                        delta_i= delta_j;
                        delta_j = temp;
                        // Console.WriteLine( );
                        // Console.Write($"{i + delta_i} {j+delta_j}");
                    }

                    i += delta_i;
                    j += delta_j;

                    // Console.Write($"{i + delta_i} {j+delta_j}");
                    
                }
              
                MyLibraryClass.PrintArrayMassiv(matrix);
            }
            Task58();

        }
    }
}


            // Task 54
						
			// 			{
            //     int rows = 4;
            //     int columns = 4;
            //     int[,]matrix = new int[rows,columns];
            //     MyLibraryClass.FillArrayMassivMinMax(matrix, 0, 10);
            //     MyLibraryClass.PrintArrayMassiv(matrix);
            //     int count = 0;

            //     for (int i=0; i< rows; i++)
            //     {
            //         int indexMinColumn=0;
            //         for (int j=0; j<columns; j++)
            //         {
            //             while (j<columns)
            //             {
            //                 if (matrix[i,j]<matrix[i,indexMinColumn])
            //                 {
            //                     int temp = matrix[i,j];
            //                     matrix[i,j]=matrix[i,indexMinColumn];
            //                     matrix[i,indexMinColumn]=temp;
            //                 }
            //                 j++;
            //             }
            //             count++;
            //             indexMinColumn=0+count;
            //             j=0+count;
            //         }

            //     }
                
            //     Console.WriteLine();
            //     MyLibraryClass.PrintArrayMassiv(matrix);
