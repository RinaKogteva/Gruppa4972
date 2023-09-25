﻿// int a = int.Parse(Console.ReadLine());
// if (a < 0) a = -a;
// for(int i = -a; i <= a; i++){
//     Console.Write(i);
//     Console.Write(" ");
// }

// int N = int.Parse(Console.ReadLine()??"0");
// int minusN = -N;
// for(int i = -N; i <= N; i++)
// {
//     Console.Write(i.ToString()+ " ");
// }

int NumN = int.Parse(Console.ReadLine()??"0");
int evNumN = (-1)*NumN;

while (evNumN < NumN)
{
   Console.Write (evNumN + ", ");
   evNumN++;
}
  Console.WriteLine (NumN);