using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;



namespace SimulacionTarea1
{
    class Program
    {

        public static void Main(string[] args)
        {
            decimal total = 100, num;
            decimal[] cartas = new decimal[10];
            int sacarCartas;


            Random rand = new Random();
            int c1, c2, c3, c4, c5, c6, c7, c8, c9, c10;

            for (int x = 0; x <= 9; x++)
            {
                Console.WriteLine("Probabilidad de Carta {0}:", x + 1);
                cartas[x] = decimal.Parse(Console.ReadLine());
                if (cartas[x] > total) { Console.WriteLine("No puedes asignarle una provavilidad mayor a la disponible"); }
                total -= cartas[x];
                Console.WriteLine("------------------------------------------");

                cartas[x] = cartas[x] / 100;
                if (total == 0) { Console.WriteLine("total de probabilidad asignadas.\n"); break; }
                Console.WriteLine("Quedan {0}% de Probabilidad por asignar\n", total);
            }


            cartas[1] = cartas[1] + cartas[0];
            cartas[2] = cartas[2] + cartas[1];
            cartas[3] = cartas[3] + cartas[2];
            cartas[4] = cartas[4] + cartas[3];
            cartas[5] = cartas[5] + cartas[4];
            cartas[6] = cartas[6] + cartas[5];
            cartas[7] = cartas[7] + cartas[6];
            cartas[8] = cartas[8] + cartas[7];
            cartas[9] = cartas[9] + cartas[8];


            Console.WriteLine("Cuantas cartas deseas sacar ?");
            sacarCartas = int.Parse(Console.ReadLine());
            c1 = c2 = c3 = c4 = c5 = c6 = c7 = c8 = c9 = c10 = 0;

            for (int x = 1; x <= sacarCartas; x++)
            {
                num = rand.Next(1, 100);
                num = num / 100;
                Console.WriteLine("Numero Random: {0}", num);

                if (cartas[0] >= num)
                {
                    c1 = c1 + 1;
                }

                if (cartas[1] >= num && num > cartas[0])
                {
                    c2 = c2 + 1;
                }

                if (cartas[2] >= num && num > cartas[1])
                {
                    c3 = c3 + 1;
                }
                if (cartas[3] >= num && num > cartas[2])
                {
                    c4 = c4 + 1;
                }
                if (cartas[4] >= num && num > cartas[3])
                {
                    c5 = c5 + 1;
                }
                if (cartas[5] >= num && num > cartas[4])
                {
                    c6 = c6 + 1;
                }
                if (cartas[6] >= num && num > cartas[5])
                {
                    c7 = c7 + 1;
                }
                if (cartas[7] >= num && num > cartas[6])
                {
                    c8 = c8 + 1;
                }
                if (cartas[8] >= num && num > cartas[7])
                {
                    c9 = c9 + 1;
                }
                if (cartas[9] >= num && num > cartas[8])
                {
                    c10 = c10 + 1;
                }
            }

            Console.WriteLine("\n Resultado: \n");
            Console.WriteLine("Carta 1 con probabilidad de {0} - {1}: Salio {2} Veces\n", 0, cartas[0], c1);
            Console.WriteLine("Carta 2 con probabilidad de {0} - {1}: Salio {2} Veces\n", cartas[0], cartas[1], c2);
            Console.WriteLine("Carta 3 con probabilidad de {0} - {1}: Salio {2} Veces\n", cartas[1], cartas[2], c3);
            Console.WriteLine("Carta 4 con probabilidad de {0} - {1}: Salio {2} Veces\n", cartas[2], cartas[3], c4);
            Console.WriteLine("Carta 5 con probabilidad de {0} - {1}: Salio {2} Veces\n", cartas[3], cartas[4], c5);
            Console.WriteLine("Carta 6 con probabilidad de {0} - {1}: Salio {2} Veces\n", cartas[4], cartas[5], c6);
            Console.WriteLine("Carta 7 con probabilidad de {0} - {1}: Salio {2} Veces\n", cartas[5], cartas[6], c7);
            Console.WriteLine("Carta 8 con probabilidad de {0} - {1}: Salio {2} Veces\n", cartas[6], cartas[7], c8);
            Console.WriteLine("Carta 9 con probabilidad de {0} - {1}: Salio {2} Veces\n", cartas[7], cartas[8], c9);
            Console.WriteLine("Carta 10 con probabilidad de {0} - {1}: Salio {2} Veces\n", cartas[8], cartas[9], c10);


        }
    }
}
