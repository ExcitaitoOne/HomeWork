//В двумерном массиве целых чисел. Удалить строку и столбец, 
//на пересечении которых расположен наименьший элемент.
Console.WriteLine("Ведите размерность массива");
int n = int.Parse(Console.ReadLine() ?? "0");
int m = int.Parse(Console.ReadLine() ?? "0");
int a = 0;
int b = 0;
void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 100);
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

int MinElement(int[,] arr, ref int min, ref int a, ref int b)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (min > arr[i, j])
            {
                min = arr[i, j];
                a = i;
                b = j;
            }

        }

    }
    return min;
}

void DeleteTable(int[,] arr,  int min)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, a] = -1;
            arr[b, j] = -1;
        }
    }
}

void FillMatrix(int[,] arr)
{

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            if (arr[i, j] != -1)
            {
                Console.Write(" " + arr[i, j]);
                
            }
            
        }
        Console.WriteLine();  
    }
}

int[,] array = new int[n, m];
int[,] matix = new int[n - 1, m - 1];

FillArray(array);
PrintArray(array);

int min = array[0, 0];

min = MinElement(array, ref min, ref a, ref b);
Console.WriteLine(" i= " + a + " j= " + b);
DeleteTable(array, min);
PrintArray(array);
FillMatrix(array);



