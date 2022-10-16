Console.Write("Введите размер стороны квадратной матрицы: ");
int size = Convert.ToInt32(Console.ReadLine());
int matrix = new int[size, size];
PopulateSpiral(matrix);

void PopulateSpiral(int[,] matrix)
{
    int num = 1;
    int max = matrix.GetLength(0) * matrix.GetLength(1);
    int step = matrix.GetLength(0);
    int turns = 0;
    while (num <= max)
    {
        for (int two = 0; two < 2; two++)
        {
            for (int i = 0; i < matrix.GetLength(0) - turns; i++)
            {
                
            }
        }
    }
}