using System;
using System.Globalization;

namespace Vetor_Exercicio {
    class Program {
        static void Main(string[] args) {
            int n;
            double[] vect;
            string[] vect2;
            n = int.Parse(Console.ReadLine());
            vect = new double[n];
            vect2 = Console.ReadLine().Split(' ');

            for(int i = 0; i < n; i++) {
                vect[i] = double.Parse(vect2[i], CultureInfo.InvariantCulture);
            }

            for(int i = 0; i < n; i++) {
                Console.Write(vect[i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }

            Console.WriteLine();

            double soma = 0.0;
            for (int i = 0; i < n; i++) {
                soma += vect[i];
            }

            double media = 0.0;
            for (int i = 0; i < n; i++) {
                media += vect[i] / 4;
            }

            Console.WriteLine("Soma: " + soma.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine("Media: " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

