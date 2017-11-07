using System;


namespace TAP1718_GitTreasureHunt
{
    class Program
    {
        public static void Main(string[] args)
        {

            new File(1000, "Carlo Felice").DoSomething();
            new File(450, "Carlo Felice").DoSomethingBad();
            new File(800, "Carlo Felice").DoSomethingGood();
        }
    }
}
