// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
int[,] matrix = InitMatrix(5,6); 
int[,] InitMatrix(int m, int n) 
{     int [,] resultMatrix = new int[m,n]; 
Random rnd = new Random();      
for (int i = 0; i < m; i++)   
  {   
    for (int j = 0; j < n; j++)        
   {   resultMatrix[i,j] = rnd.Next(1,99); }  
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
PrintMatrix(matrix);

int GetNumber(string message) 
{     Console.WriteLine(message);     
int number = int.Parse(Console.ReadLine());    
return number; } 
int m = GetNumber("Введите номер строки m:"); 
int n = GetNumber("Введите номер столбца n:"); 
if (m<5 && n<6)
{
    Console.Write($"{matrix[m,n]}  "); 
} 
else
 {
    Console.Write("такого числа в массиве нет "); 
} 
