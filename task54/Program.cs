/*Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

Console.Clear();
int[,]GetArray(int m, int n, int minValue, int maxValue)
{
    int[,]result=new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
          result[i,j]=new Random().Next(minValue,maxValue);  
        }
    }
    return result;
}
void PrintArray(int[,]inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
          Console.Write($"{inArray[i,j]}\t");  
        }
        Console.WriteLine();
    }
}
void minmaxValue(int[,]array)
{
    
    int countcol= array.GetLength(1);
    int max =0; 
    
    for (int delta = 0; delta < array.GetLength(0); delta++)
    {
        
    
    for (int i = 0; i < countcol; i++)
    {
        
     
    for (int j = 0; j <countcol; j++)
    {
       if (array[delta,i]>array[delta,j])
       {
        max=array[delta,i];
        array[delta,i]=array[delta,j];
        array[delta,j]=max;
       } 
       
        
    }
    
    }
    }
  
        Console.WriteLine();
}
int[,] array1 = GetArray(4, 5, 0, 10);
        PrintArray(array1);
        Console.WriteLine();
        minmaxValue(array1);
        PrintArray(array1);