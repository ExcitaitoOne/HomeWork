// Написать программу показывающие первые N чисел, для которых каждое 
//следующее равно сумме двух предыдущих.
// Первые два элемента последовательности задаются пользователем
Console.WriteLine("Ведите отрезок N");
int N = int.Parse(Console.ReadLine() ?? "0");
int D = 0;
Console.WriteLine("Введите 2 числа ");
int B = int.Parse(Console.ReadLine() ?? "0");
int M = int.Parse(Console.ReadLine() ?? "0");
int sum = 0;

string Rec(int M, int B){

    if (D!=N){
        D++; 
    B = M + B;
    return $"{sum = B + M} "  + Rec(B,M);
    }
    else return string.Empty;
}

 Console.Write(Rec(B,M)); 