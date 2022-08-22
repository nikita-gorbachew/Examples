﻿//string[,] table = new string[2, 5];
//StringEmpty
//table [0,0]
//table [0,1]
/* //таблица
table[1, 2] = "слово";
for (int rows = 0; rows < 2; rows++)
{
   for (int columns = 0; columns < 5; columns++)
   {
    Console.WriteLine($"-{table[rows, columns]}-");
   }
}
*/

/* //массив
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}
int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
*/

/* // картинка
int[,] pic = new int[,]
{
    {0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, },
    {0, 0, 0, 1, 1, 0, 0, 0, 0, 0 ,0, 0, 0, 1, 1, 0, 0, 0, },
    {0, 0, 0, 1, 1, 0, 0, 0, 0, 0 ,0, 0, 0, 1, 1, 0, 0, 0, },
    {0, 0, 0, 1, 1, 0, 0, 0, 0, 0 ,0, 0, 0, 1, 1, 0, 0, 0, },
    {0, 0, 0, 1, 1, 0, 0, 0, 0, 0 ,0, 0, 0, 1, 1, 0, 0, 0, },
    {0, 0, 0, 1, 1, 0, 0, 0, 0, 0 ,0, 0, 0, 1, 1, 0, 0, 0, },
    {0, 0, 0, 1, 1, 0, 0, 0, 0, 0 ,0, 0, 0, 1, 1, 0, 0, 0, },
    {0, 0, 0, 1, 1, 0, 0, 0, 0, 0 ,0, 0, 0, 1, 1, 0, 0, 0, },
    {0, 0, 0, 1, 1, 0, 0, 0, 0, 0 ,0, 0, 0, 1, 1, 0, 0, 0, },
    {0, 0, 0, 1, 1, 0, 0, 0, 0, 0 ,0, 0, 0, 1, 1, 0, 0, 0, },
    {0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, },
};

void PtintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            //Console.Write($"{image[i, j]} ");
            if(image[i, j] == 0) Console.Write($" ");
            else Console.Write($"+");
        }
        Console.WriteLine();
    }
}
void FillImage(int row, int col)
{
    if(pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FillImage(row-1, col);
        FillImage(row, col-1);
        FillImage(row+1, col);
        FillImage(row, col+1);
    }
}

PrintImage(pic);
FillImage(5, 5);
PrintImage(pic);
*/

//факториал
/*
double Factorial (int n)
{
    if(n == 1) return 1;
    else return n * Factorial(n - 1);
}    
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");

}
*/

//f(1) = 1
//f(2) = 1
//f(n) = f(n-1) + f(n-2)

int Fibonacci (int n)
{ 
    if( n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}
for (int i = 1; i < 50; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}   