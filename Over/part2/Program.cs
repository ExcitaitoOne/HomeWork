// Найти сумму элементов от M до N, N и M заданы
Console.WriteLine("Ведите отрезок NM");
int N = int.Parse(Console.ReadLine() ?? "0");
int M = int.Parse(Console.ReadLine() ?? "0");
int sum = 0;
string Rec(int N, int M){
    if (N <= M) return $"{sum += N}"  + Rec(N+1,M);
    else return string.Empty;
}
Rec(N,M);
Console.WriteLine("="+sum);