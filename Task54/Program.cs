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

int[,] Average(int[,] matrix)
{
    int [,] average = new int[matrix.GetLength(0),matrix.GetLength(1)];
    int znac = 0;
    for (int i = 0; i < matrix.GetLength(0) -1; i++)
    {
        // int znac = 0;
      for (int j = 0; j < matrix.GetLength(1)-1; j++)
      {
         if (matrix[i,j] < matrix [i+1,j+1])
            {
                znac = matrix [i +1,j+1] ;
                matrix [i +1,j+1] = matrix[i,j];
                matrix[i,j] = znac;
            }
        average[i,j] = matrix[i,j] ;
      }  

    }
     return average;







    // int[] average = new int [matrix.GetLength(1)];
    // for (int i = 1; i < matrix.GetLength(0); i++)
    // {
    //     int max = matrix[0,0];
    //     for (int j = 1; j < matrix.GetLength(1); j++)
    //     {
    //         if (matrix[i,j]> max)
    //         {
    //             max = matrix[i,j];
    //         }
    //     }
    //     average[i] = max;
    // }
    // return average;
}

// bool checkCoordinates(int cI, int cJ, int[,] m)
// {
//     if (cI < 0)
//     {
//         Console.WriteLine("Координата i меньше нуля");
//         return false;
//     }
//     if (cJ < 0)
//     {
//         Console.WriteLine("Координата j меньше нуля");
//         return false;
//     }
//     if (cI >= m.GetLength(0))
//     {
//         Console.WriteLine("Координата i больше размера строки");
//         return false;
//     }
//     if (cJ >= m.GetLength(1))
//     {
//         Console.WriteLine("Координата j больше размера столбца");
//         return false;
//     }
//     return true;
// }

int [,] array2D = CreateMatrixRndInt(3,4,-10,10);
PrintMatrix(array2D);
Console.WriteLine();
int [,] array = Average(array2D);
PrintMatrix(array);

// Console.Write("Введите число i:");
// int numI = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число j:");
// int numJ= Convert.ToInt32(Console.ReadLine());

// bool correct = checkCoordinates(numI, numJ, array2D);
// if (!correct)
// {
//     return;
// }

// int number = array2D[numI, numJ];
// Console.WriteLine($"{number}");
