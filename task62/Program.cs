/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/


internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        int[,] GetArray(int m, int n, int minValue, int maxValue)
        {
            int[,] result = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    result[i, j] = new Random().Next(minValue, maxValue);
                }

            }
            return result;
        }
        void PrintArray(int[,] inArray)
        {
            for (int i = 0; i < inArray.GetLength(0); i++)
            {
                for (int j = 0; j < inArray.GetLength(1); j++)
                {
                    Console.Write($"{inArray[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
        void zmeyka(int[,] array)
        {            
     
            int count = array.GetLength(0);
            int num = 1;
            
         for (int index = 0; index < count-index; index++)
         {
            
         
            for (int i = 0 + index; i < count - index; i++)
            {
                array[0 + index, i] = num;
                num++;
            }
            num--;
            for (int i = 0 + index; i < count - index; i++)
            {
                array[i, 4 - index] = num;
                num++;
            }
            num--;
            for (int i = count - 1 - index; i >= 0 + index; i--)
            {
                array[4 - index, i] = num;
                num++;
            }
            num--;
            for (int i = count - index - 1; i >= 0 + index + 1; i--)
            {
                array[i, 0 + index] = num;
                num++;
            }
         }
        }
        int[,] array = GetArray(5, 5, 0, 0);
        PrintArray(array);
        Console.WriteLine();
        zmeyka(array);
        PrintArray(array);
    }
}