using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturasDeDados
{
    internal class Program
    {
        const int max = 3;

        static void Main(string[] args)
        {
            //Lista Linear Sequencial
            int[] arranjo = new int[max + 1];
            arranjo[0] = 25;
            arranjo[1] = 4;
            arranjo[2] = 333;

            Console.Write("Digite sua escolha: "); int escolha = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Posição: {BuscaLinearSequencial(arranjo, escolha)}"); 
            Console.WriteLine($"Posição: {BuscaLinearSequencial2(arranjo, escolha)}");

            Console.ReadLine();
        }

        public static int BuscaLinearSequencial(int[] arranjo, int chave)
        {
            int i = 0;
            while (i < arranjo.Length)
            {
                if (chave == arranjo[i])
                    return i;
                else
                    i++;
            }
            return -1;
        }

        public static int BuscaLinearSequencial2(int[] arranjo, int chave)
        {
            int i = 0;
            int sentinela = chave;
            arranjo[max] = sentinela;

            while (arranjo[i] != chave) i++;
            if (i == sentinela)
                return -1;
            else
                return i;
        }
    }
}
