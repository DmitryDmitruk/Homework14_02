/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/


Console.Clear();

int[,]GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result=new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
          result[i,j]= new Random().Next(minValue,maxValue);
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
void zmeyka(int[,]array)
{
   
     int  count= array.GetLength(0);
     int num =1;
     int index=1;
   
   for (int i = 0; i < count; i++)
   {
    array[0,i]=num;
    num++;
   } //   1r
   num--;
   for (int i = 0;  i< count; i++)
   {
    array[i,4]=num;
    num++;    
   }//2c
   num--;
   for (int i = count-1; i >=0; i--)
   {
    array[4,i]=num;
    num++;
   } //3r
   num--;
   for (int i = count-1; i >=1; i--)
   {
    array[i,0]=num;
    num++;
   }//4c
   for (int i = 0+index; i < count-index; i++)
   {
    array[1,i]=num;
    num++;
   }//5
   for (int i = 0+index+1; i < count-index; i++)
   {
    array[i,3]=num;
    num++;
   }//6
   for (int i = count-index-1; i > 0+index; i--)
   {
    array[3,i-index]=num;
    num++;
   }//7
   for (int i = 0+index; i < count-index-1; i++)
   {
    array[2,i]=num;
    num++;
   }//8
   
}
int[,]array=GetArray(5,5,1,1);
PrintArray(array);
Console.WriteLine();
zmeyka(array);
PrintArray(array);