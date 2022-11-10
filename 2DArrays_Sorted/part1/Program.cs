//Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

Console.WriteLine("Введите размерность двухмерного массива");
int n = int.Parse(Console.ReadLine() ?? "0");
int m = int.Parse(Console.ReadLine() ?? "0");

void FillArr(int[,] arr)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Console.Write(" " + arr[i, j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int MaxArray(int[,] arr, int arg, int max)
{

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            if (max < arr[arg, j])
            {
                max = arr[arg, j];
            }
        }
    }
    return max;
}

void sortLine(int[,] arr, int arg)
{
    int temp = arr[0, 0];
    int max = temp;
    max = MaxArray(arr, arg, max);

    int ind = 0;
    while (ind < n - 1)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {

            if (i >= 0 && i + 1 >= 0 && i + 1 < n)
            {
                if (arr[arg, i] < arr[arg, i + 1])
                {
                    temp = arr[arg, i + 1];
                    arr[arg, i + 1] = arr[arg, i];
                    arr[arg, i] = temp;
                }
            }
        }
    ind++;
    }
}


int[,] Arrays = new int[n, m];
FillArr(Arrays);
PrintArray(Arrays);

for (int i = 0; i < m; i++){
sortLine(Arrays, i);
}

PrintArray(Arrays);

