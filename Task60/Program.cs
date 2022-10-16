int[,,] CreateMatrixInt(int rows, int columns, int depth)
{
    int num = 10;
    int [,,] matrix = new int[rows, columns, depth];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
        for (int f = 0; f < matrix.GetLength(2); f++)
        {
          matrix[i,j,f] = num;
          num++;  
        }
      }  
    }
    return matrix;
}

void PrintMatrix (int[,,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    Console.Write("|");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int f = 0; f < matrix.GetLength(2); f++)
        {
            Console.Write($"{matrix[i,j,f],3} ({i},{j},{f})|"); 
        }
    }   
     Console.WriteLine("");   
}
}


int [,,] array3D = CreateMatrixInt(2,2,2);
PrintMatrix(array3D);






