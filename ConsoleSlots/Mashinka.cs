using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace mashinki
{
    public class Mashinka
    {

        public double Balance { get; set; }

        public List<Coin> coins;
        public Mashinka()
        {

            CoinMaker cm = new CoinMaker();
            coins = CoinMaker.GetCoins().ToList();
            Balance = 500.0;
        }

        public static int rows = 4;
        public static int cols = 5;
        public static int zalog = 10;
        public Coin[,] matrix = new Coin[rows, cols];

        public void Roll()
        {

            Random rnd = new Random();





            //  while (Balance > 0)
            //{
            Console.WriteLine("\nBalans: " + Balance);    // izpisva obshto pari i vuvejda zalog
            Console.Write("Zalog: 10 ");
            //Console.ReadLine();

            Balance -= zalog;
            Console.WriteLine();

            for (int i = 0; i < rows; i++)                  //izbira i izpisva iconki
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = coins.ElementAt(rnd.Next(0, 8));
                    Console.Write(" " + matrix[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();


            /*for (int i = 0; i < rows; i++)
            {
                ProverkaNaRed(i);
            }

            //}
            Console.WriteLine("Gubish");*/

        }

        public void ProverkaNaRed(int izbranRed)
        {
            Coin reference = null;

            for (int i = 0; i < cols; i++)                   //dava stoinost na referenciqta
            {
                if (matrix[izbranRed, i].Name != "X")
                {
                    reference = matrix[izbranRed, i];
                    break;
                }
            }



            bool IsAWin = true;

            if (reference == null) { reference = new Coin("X", 15.0); }

            for (int i = 0; i < cols; i++)           //proverqva red za pobeda
            {
                if (matrix[izbranRed, i].Name != reference.Name && matrix[izbranRed, i].Name != "X")
                {
                    IsAWin = false;
                }
            }


            if (IsAWin)         //deklarira pobeda/zaguba i dava pari
            {

                Balance += zalog * reference.Markliplier;
                Console.WriteLine($"Liniq {izbranRed + 1}: Win ot {reference.Name}. Pari ot liniq: {reference.Markliplier * zalog}");
                Console.WriteLine();

            }
            else
            {
                Console.WriteLine($"Liniq {izbranRed + 1}: Chep");
                Console.WriteLine();
            }
        }

    }
}
