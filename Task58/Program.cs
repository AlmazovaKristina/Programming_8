int[,] CreateMatrixRndInt(int rows,int columns,int min,int max)
{
    int [,] matrix = new int[rows,columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
        matrix[i,j] = rnd.Next(min,max + 1);
      }  
    }
    return matrix;
}

void PrintMatrix (int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    Console.Write("|");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
            Console.Write($"{matrix[i,j],5} |");
    }   
     Console.WriteLine("");   
}
}


int[,] Multiply(int[,] matrixP, int[,] matrixK)
{
    // kjasdgfjkdshgf
    int[,] result = new int[matrixP.GetLength(0), matrixK.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrixP.GetLength(1); k++)
            {
                sum += matrixP[i, k] * matrixK[k, j];
            }
            result[i, j] = sum;
        }

    }
    return result;
}


int [,] array2DP = CreateMatrixRndInt(4,2,-10,10);
PrintMatrix(array2DP);
Console.WriteLine();
int [,] array2DK = CreateMatrixRndInt(2,3,-10,10);
PrintMatrix(array2DK);
Console.WriteLine();
int [,] array2DC = Multiply(array2DP, array2DK);
PrintMatrix(array2DC);
Console.WriteLine();
// int number = FindMinNumberLine (array2D);
// Console.WriteLine($"Строка {number + 1}");




