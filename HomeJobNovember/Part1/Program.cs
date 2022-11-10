// Найти произведение двух матриц

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write("  " + arr[i, j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void productMatrix(int[,] arr, int[,] mat, int[,] summ)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for(int n = 0; n < 3; n++ ){
                  summ[j,n] = (arr[j,n] * mat[n,j]) + (arr[j,n] * mat[n,j]) + (arr[j,n] * mat[n,j]);
            }
        }
    }
}
int[,] array = new int[3, 3];
int[,] matrix = new int[3, 3];
int[,] summ = new int[3, 3];

FillArray(array);
FillArray(matrix);
PrintArray(array);
PrintArray(matrix);

productMatrix(array, matrix, summ );
PrintArray(summ);