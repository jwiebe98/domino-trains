using static dominos.Board;

namespace dominos
{
    public interface IBoard
    {
        public TrainStation trainStation { get; }

        public bool PlayDomino(Player player, Direction direction, Domino domino);
    }

    public class Board : IBoard
    {
        public TrainStation trainStation { get; } = new();

        public bool PlayDomino(Player player, Direction direction, Domino domino)
        {
            var playedDomino = trainStation.GetTrain(direction).AddDomino(domino);

            if (!playedDomino)
                return false;

            player.hand.Remove(domino);
            return true;
        }
        public enum Direction
        {
            North,
            East,
            South,
            West
        };
    }
}
