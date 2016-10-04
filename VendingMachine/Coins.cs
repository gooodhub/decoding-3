namespace VendingMachine
{
    public class Coins
    {
        public double[] Types { get; }

        public Coins()
        {
            Types = new double[10];
            Types[0] = .01;
            Types[1] = .02;
            Types[2] = .05;
            Types[3] = .10;
            Types[4] = .20;
            Types[5] = .50;
            Types[6] = 1;
            Types[7] = 2;
            Types[8] = 5;
            Types[9] = 10;
        }

    }
}
