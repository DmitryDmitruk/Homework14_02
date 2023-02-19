/* Задача 58: Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/
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
int[,]MatrixProduct(int[,]arrayA, int[,]arrayB)
{
   int yA=arrayA.GetLength(0);
   int xA=arrayA.GetLength(1);
   int yB=arrayB.GetLength(0);
   int xB=arrayB.GetLength(1);
   int matrixProdukt=0;
   int[,]result= new int[yA,xB];
   for (int i = 0; i <yA ; i++)
   {
    for (int j = 0; j < xB; j++)
    {
        for (int k = 0; k < yB; k++)
        {
           matrixProdukt+= arrayA[i,k]*arrayB[k,j] ;
        }
        result[i,j]=matrixProdukt;
    }
   }
   return result;
}
int[,]arrayA=GetArray(2,2,0,10);
PrintArray(arrayA);
Console.WriteLine();
int[,]arrayB=GetArray(2,2,0,10);
PrintArray(arrayB);
Console.WriteLine();
PrintArray(MatrixProduct(arrayA, arrayB));

