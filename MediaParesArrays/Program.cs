//Utilizando Arrays:
//Problema "media_pares "
//Fazer um programa para ler um vetor de N números inteiros. Em seguida, mostrar na tela a média
//aritmética somente dos números pares lidos, com uma casa decimal. Se nenhum número par for
//digitado, mostrar a mensagem "NENHUM NUMERO PAR" 

using System.Globalization;

namespace MediaParesArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, somaPares = 0, contPares = 0;
            double mediaPares;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Quantos elementos vai ter o vetor? ");
            n = int.Parse(Console.ReadLine());

            int[] vet = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite um numero: ");
                vet[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                if (vet[i] % 2 == 0)
                {
                    somaPares = somaPares + vet[i];
                    contPares++;
                }
            }

            if (contPares == 0)
            {
                Console.WriteLine("NENHUM NUMERO PAR");
            }
            else
            {
                mediaPares = (double)somaPares / contPares;
                Console.WriteLine($"MEDIA DOS PARES = {mediaPares.ToString("F1", CI)}");
            } 
        }
    }
}
