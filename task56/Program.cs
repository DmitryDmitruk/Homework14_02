/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт 
номер строки с наименьшей суммой элементов: 1 строка*/
Console.Clear();
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,]result=new int[m,n];
    for (int i = 0; i <m ; i++)
    {
       for (int j = 0; j < n; j++)
       {
        result[i,j]=new  Random().Next(minValue,maxValue);
       } 
    }
    return result;
}
void PrintArray(int[,]inArray)
{
    for (int i = 0; i < inArray.GetLength(0) ; i++)
    {
      for (int j = 0; j < inArray.GetLength(1); j++)
      {
        Console.Write($"{inArray[i,j]}\t");
      }
      Console.WriteLine();  
    }
}
int[] NumbersSum(int[,]array)
{
    
    int[]sum=new int[array.GetLength(0)];
    for(int i=0;i<array.GetLength(0);i++)
     {
        int sum0=0;
        for (int j = 0; j < array.GetLength(1); j++)    
         {
           sum0= sum0+array[i,j];
         }
        sum[i]=sum0;
     } 
     return sum ; 

     
}
void MinSum(int[]res)
{
       int count=0;
       int min=res[count];       
    
      for (int i = 0; i < res.Length; i++)
      {
        
        if (res[i]<res[count])
        {
          count =i;          
        }
        
         
      }
      
      Console.WriteLine($"Номер строки снаименьшей суммой элементов {count}");
    
}
int[,]array2=GetArray(4,3,0,10);
PrintArray(array2);
Console.WriteLine();
int[]sum=NumbersSum(array2);

Console.WriteLine($"{String.Join(" ; " , sum)}");
MinSum(sum);


