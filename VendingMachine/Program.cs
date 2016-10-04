namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client();
            var machine = new Machine();
            var chosenSnack = client.MakeChoice(machine.Snacks);
            machine.SelectSnack(chosenSnack);
            while (!machine.ThrowProduct())
            {
                machine.GetMoney(client.InsertCoin());
            }

        }
    }
}
