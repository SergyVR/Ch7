// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] matrix = InitMatrix(5,6); 
int[,] InitMatrix(int m, int n) 
{     int [,] resultMatrix = new int[m,n]; 
Random rnd = new Random();      
for (int i = 0; i < m; i++)   
  {   
    for (int j = 0; j < n; j++)        
   {   resultMatrix[i,j] = rnd.Next(1,10); }  
  }
    return resultMatrix;
 } 

 void PrintMatrix(int[,] matrix) 
 {     for (int i = 0; i < matrix.GetLength(0); i++) 
  {    for (int j = 0; j < matrix.GetLength(1); j++)
   
  {   Console.Write($"{matrix[i,j]}   ");         }        
    Console.WriteLine();     
  } 
 } 
PrintMatrix(matrix);
Console.WriteLine(); 
double summ = 0;
 void PrintSumm(int[,] matrix) 
 {   for (int j = 0; j < matrix.GetLength(1); j++)  
 
  {  for (int i = 0; i < matrix.GetLength(0); i++)   
         
  {  summ = summ + matrix[i,j];           }    
      summ = summ / matrix.GetLength(0);
      Console.Write($"{summ}  "); 
      summ = 0;  
  } 
 } 
PrintSumm(matrix);