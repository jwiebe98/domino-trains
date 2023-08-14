using static dominos.Board;

namespace dominos
{
    public interface ITrainStation
    {
        public Train[] trains { get; }

        public Train GetTrain(Direction direction);
    }

    public class TrainStation : ITrainStation
    {
        private const int NUMBER_OF_TRAINS_IN_STATION = 4;

        public Train[] trains { get; } = new Train[NUMBER_OF_TRAINS_IN_STATION] { new(), new(), new(), new() };

        public Train GetTrain(Direction direction) => trains[(int)direction];
    }
}
