using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

namespace VendingMachine
{
    class Machine
    {
        private double toPay;
        private Snack chosenSnack;
        public List<Snack> Snacks = new List<Snack>
            {
                new Snack("Mars",1.33),
                new Snack("Bounty",1.41),
                new Snack("Twix",1.50),
                new Snack("Nuts",1.27),
                new Snack("Coca Cola",2.10),
                new Snack("Sprite",2),
                new Snack("IceTea",1.92)
            };

        public void GetMoney(double amount)
        {
            toPay -= amount;
            Debug.WriteLine(string.Format(CultureInfo.InvariantCulture, "Paid: {0}", amount));
        }

        public bool ThrowProduct()
        {
            Debug.WriteLine(string.Format(CultureInfo.InvariantCulture, "To pay: {0}", toPay));
            return (toPay <= 0);
        }

        public bool ReturnMoney()
        {
            
        }

        public void SelectSnack(Snack snack)
        {
            chosenSnack = snack;
            toPay = snack.Price;
        }
    }
}
