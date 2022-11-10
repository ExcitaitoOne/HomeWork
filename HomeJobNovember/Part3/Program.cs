// Сформировать трехмерный массив не повторяющимися двузначными
// числами показать его построчно на экран выводя индексы соответствующего элемента
Console.WriteLine("Ведите размерность массива");
int n = int.Parse(Console.ReadLine() ?? "0");
int m = int.Parse(Console.ReadLine() ?? "0");
int l = int.Parse(Console.ReadLine() ?? "0");
void Array3D(int[] arr1, int[] arr2, int[] arr3)
{

    int arg = 9;
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                for (int k = 0; k < l; k++)
                {
                    if (arg != 99){
                    arr3[i] = arg;
                    arr2[j] = arg;
                    arr1[k] = arg;
                    arg++;
                    Console.Write($"i:{i} j:{j} k:{k} = {arg} ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
int[] array = new int[n];
int[] array1 = new int[m];
int[] array2 = new int[l];

Array3D(array, array1, array2);