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

int FindMinNumberLine(int[,] matrix)
{
    int min = matrix[0,0];
    int minI = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j]<= min)
            {
                min = matrix[i,j];
                minI = i;
            }
         }            
        
    }
    return minI;
}


int [,] array2D = CreateMatrixRndInt(6,4,-10,10);
PrintMatrix(array2D);
Console.WriteLine();
int number = FindMinNumberLine (array2D);
Console.WriteLine($"Строка {number + 1}");




