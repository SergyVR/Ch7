// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int GetNumber(string message) 
{   Console.WriteLine(message);     
int number = int.Parse(Console.ReadLine());     
return number; } 

int m = GetNumber("Введите число m:"); 
int n = GetNumber("Введите число n:"); 
int[,] matrix = InitMatrix(m,n); 
PrintMatrix(matrix);


int[,] InitMatrix(int m, int n) 
{     int [,] resultMatrix = new int[m,n]; 
     
for (int i = 0; i < m; i++)   
  {   
    for (int j = 0; j < n; j++)        
   {   resultMatrix[i,j] = new Random().Next(10,99); }  
  }
    return resultMatrix;
 } 

 void PrintMatrix(int[,] matrix) 
 {     for (int i = 0; i < matrix.GetLength(0); i++) 
  {    for (int j = 0; j < matrix.GetLength(1); j++)        
  {   Console.Write($"{matrix[i,j]}  ");         }        
    Console.WriteLine();     
  } 
 } 