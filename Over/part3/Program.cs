// Написать программу вычисления функции Аккермана

double N = 3;
double M = 4;

double Rec(double N, double M)
{
   if (N == 0) return M + 1; 
   else if (M == 0) return Rec(N-1,1);
   else return Rec(N-1, Rec(N,M-1));
}
Console.WriteLine(" "+ Rec(N,M));


   

