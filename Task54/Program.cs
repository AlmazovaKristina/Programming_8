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

void Sort (int[,] matrix)
{
    int znac = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        bool changed = true;
        while (changed == true)
        {
            changed = false;
            for (int j = 0; j < matrix.GetLength(1)-1; j++)
            {
                if (matrix[i,j] < matrix [i,j+1])
                {
                    znac = matrix [i,j+1];
                    matrix [i,j+1] = matrix[i,j];
                    matrix[i,j] = znac;
                    changed = true;
                }
             }            
        }
    }
}


int [,] array2D = CreateMatrixRndInt(3,4,-10,10);
PrintMatrix(array2D);
Console.WriteLine();
Sort(array2D);
PrintMatrix(array2D);


