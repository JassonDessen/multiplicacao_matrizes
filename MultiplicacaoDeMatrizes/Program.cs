using System;
using System.Threading;

namespace MultiplicacaoDeMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            // O GetUpperBound pega o último índice de uma dimensão
            // A dimensão 0 representa as linhas e a 1 representa as colunas
            // A matriz resultado vai ter a mesma quantidade de linhas que a matriz A
            // e a mesma quantidade de colunas da matriz B.

            double[,] matA, matB, matRes;
            // linhas e colunas da matriz resultado
            int linhaR, colR;

            Console.WriteLine("Multiplicação de matrizes");

            Console.WriteLine();

            Console.Write("Informe a quatidade linhas da matriz A: ");
            int linha = int.Parse(Console.ReadLine());
            Console.Write("Informe a quantidade de colunas da matriz A: ");
            int col = int.Parse(Console.ReadLine());
            matA = new double[linha, col];
            // Armazenando a quantidade de linhas para utlizar na matriz resultado
            linhaR = linha;

            Console.WriteLine();

            Console.Write("Informe a quantidade de linhas da matriz B: ");
            linha = int.Parse(Console.ReadLine());
            Console.Write("Informe a quantidade de colunas da matriz B: ");
            col = int.Parse(Console.ReadLine());
            matB = new double[linha, col];
            // Armazenando a quantidade de colunas para utilzar na matriz resultado
            colR = col;

            Console.WriteLine();

            // A multiplicação de matriz só ocorre quando a quantidade de colunas da primeira
            // matriz é igual a quantidade de linhas da segunda
            if (matA.GetUpperBound(1) != matB.GetUpperBound(0))
            {
                Console.WriteLine("Impossível realizar a multiplicação, pois a quantidade de "
                    + "colunas na matriz A não é igual a quantidade de linhas da matriz B!");
                return;
            }

            Console.WriteLine("Informe os valores dos elementos da matriz A: ");
            for (int i = 0; i <= matA.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= matA.GetUpperBound(1); j++)
                {
                    Console.Write($"A[{i + 1}, {j + 1}]: ");
                    matA[i, j] = double.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();

            Console.WriteLine("Informe os valores dos elementos da matriz B: ");
            for (int i = 0; i <= matB.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= matB.GetUpperBound(1); j++)
                {
                    Console.Write($"B[{i + 1}, {j + 1}]: ");
                    matB[i, j] = double.Parse(Console.ReadLine());
                }
            }

            // Criando a matriz resultado
            matRes = new double[linhaR, colR];

            // Realizando a multiplicação de matriz
            for (int i = 0; i <= matRes.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= matRes.GetUpperBound(1); j++)
                {
                    // A quantidade de vezes que esse laço deve se repetir é igual
                    // a quantidade de colunas da matriz A ou a quantidade de
                    // linhas da matriz B.
                    // Laço responsável pela multiplicação dos elementos.
                    for (int k = 0; k <= matB.GetUpperBound(0); k++)
                    {
                        matRes[i, j] += matA[i, k] * matB[k, j];
                    }
                }
            }

            Console.WriteLine();

            Console.WriteLine("Resultado: ");
            for (int i = 0; i <= matRes.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= matRes.GetUpperBound(1); j++)
                {
                    Console.Write(matRes[i, j] + " ");
                    Thread.Sleep(200);
                }
                Console.WriteLine();
            }
        }
    }
}
