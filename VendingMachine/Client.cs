using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

namespace VendingMachine
{
    class Client
    {
        private Coins _coins;

        private Coins Coins
        {
            get
            {
                if (_coins == null) _coins = new Coins();
                return _coins;
            }
        }

        public Snack MakeChoice(List<Snack> snacks)
        {
            Random random = new Random();
            var index = random.Next(0, snacks.Count);
            Debug.WriteLine(string.Format(CultureInfo.InvariantCulture, "Chosen: {0}", snacks[index].Price));
            return snacks[index];
        }

        public double InsertCoin()
        {
            Random random = new Random();
            var index = random.Next(0, Coins.Types.Length);
            return Coins.Types[index];
        }
    }
}
