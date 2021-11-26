namespace Task_4
{
    public class ComputerNetwork
    {
        public string Title;
        public int NumberStations;
        public double AverageDistance;

        public ComputerNetwork(string title, int numberStations, double averageDistance)
        {
            Title = title;
            NumberStations = numberStations;
            AverageDistance = averageDistance;
        }

        public virtual double Q()
        {
            return NumberStations * AverageDistance;
        }
    }
}
