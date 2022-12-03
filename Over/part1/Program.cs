// Показать натуральные числа от M до N, N и M заданы
Console.WriteLine("Ведите отрезок NM");
int N = int.Parse(Console.ReadLine() ?? "0");
int M = int.Parse(Console.ReadLine() ?? "0");

string Rec(int N,int M){
    if (N <= M) return $" {N}" + Rec(N+1,M);
    else return string.Empty;
   
}
Console.WriteLine(Rec(N,M));