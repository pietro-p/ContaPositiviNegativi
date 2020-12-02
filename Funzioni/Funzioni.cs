using System;

namespace Funzioni
{
    public class Funzioni
    {
        public static int InserisciNumeroInt()
        {
            int n;
            do
            {
                Console.Write("inserisci un numero intero: ");
                n = int.Parse(Console.ReadLine());
            } while (n < 0);
            return n;
        }
        public static void ContaPariDispari(int a, int b)
        {
            int contaPari = 0;
            int contaDispari = 0;
            int max = Math.Max(a, b);
            int min = Math.Min(a, b);
            for (int i = min; i <= max; i++)
            {
                if (i%2==0)
                {
                    contaPari++;
                    Console.WriteLine($"{i} pari");
                }
                else
                {
                    contaDispari++;
                    Console.WriteLine($"{i} Dispari");
                }
            }
            Console.WriteLine($"I positivi sono:{contaPari}\n" +
                $"I negativi sono:{contaDispari}");
            
        }
    }
}
