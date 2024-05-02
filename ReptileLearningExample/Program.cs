namespace ReptileLearningExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tank myTank = new Tank(4, 20);
            BallPython myFirstPython = new BallPython("Susie the Snake", 2, 0.17f);
            BallPython mySecondPhythong = new BallPython("Footlong Frank", 1, 0.09f);
            BeardedDragon myFirstBeareded = new BeardedDragon("Spike", 6, 9);
            BeardedDragon secondDragon = new BeardedDragon("Beardy", 3, 1);

            myTank.AddInhabitant(myFirstPython);
            myTank.AddInhabitant(mySecondPhythong);
            myTank.AddInhabitant(myFirstBeareded);
            myTank.AddInhabitant(secondDragon);
            Mouse theFeedMouse = new Mouse("Timmy", 1, 0.1f, 2);
            myTank.Feed(theFeedMouse);
            myTank.ListInhabitants();
        }
    }
}
