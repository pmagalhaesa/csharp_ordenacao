using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        class Exercicio
        {
            public static int[] inserir()
            {
                int[] vet = new int[10];

                for (int i = 0; i < vet.Length; i++)
                {
                    Console.WriteLine("Digite o " + (i + 1) + "o numero:");
                    vet[i] = int.Parse(Console.ReadLine());

                }
                return vet;
            }

            public static int[] ordena(int[] vet)
            {
                int menor= int.MaxValue; 
                int []ordenado = new int[vet.Length];
                // 2 3 8 1
                for (int i = 0; i < vet.Length; i++)
                {
                    if (i == 0) { menor = vet[i]; }
                    for (int j = 0; j < vet.Length; j++)
                    {
                        if (i != j && vet[j] != int.MaxValue && vet[j]<vet[i])
                        {
                            menor=vet[j];
                             vet[j] = int.MaxValue;
                        }
                    }

                    ordenado[i] = menor;
                }

                return ordenado;
            }
        }
        static void Main(string[] args)
        {
            int []imprime= Exercicio.ordena(Exercicio.inserir());

            for (int i = 0; i < imprime.Length; i++)
            {
                Console.WriteLine(imprime[i]);
            }

           Console.ReadKey();
        }
    }
}
