namespace Task_4
{
    public class SpeedComputerNetwork : ComputerNetwork
    {
        public readonly double Speed;

        public SpeedComputerNetwork(
            string title, int numberStations, double averageDistance, double speed
        ) : base(title, numberStations, averageDistance)
        {
            Speed = speed;
        }

        public override double Q()
        {
            return base.Q() * Speed;
        }
    }
}
