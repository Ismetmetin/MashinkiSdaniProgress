using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mashinki
{
    public class CoinMaker
    {
        static List<Coin> coins = new List<Coin>();
        public CoinMaker()
        {
            Coin surce = new Coin("♥", 3);
            Coin Vale = new Coin("J", 6);
            Coin dama = new Coin("Q", 4);
            Coin kral = new Coin("K", 4.5);
            Coin gorqshtaSedmica = new Coin("7", 7);
            Coin Aso = new Coin("A", 5);
            Coin dinq = new Coin("D", 2);
            Coin joker = new Coin("X", 15);
            coins.Add(surce);
            coins.Add(Vale);
            coins.Add(dama);
            coins.Add(kral);
            coins.Add(joker);
            coins.Add(dinq);
            coins.Add(Aso);
            coins.Add(gorqshtaSedmica);
        }

        public static List<Coin> GetCoins()
        {
            return coins;
        }

    }
}
