namespace dominos
{
    public interface IPlayer
    {
        public List<Domino> hand { get; set; }

        public bool HasAnyMoves(Board board);

        public int GetScore();
    }

    public class Player : IPlayer
    {
        public List<Domino> hand { get; set; } = new();

        public bool HasAnyMoves(Board board)
            => hand.Any(domino => board.trainStation.trains.Any(train => train.IsValidMove(domino)));

        public int GetScore() => hand.SelectMany(domino => domino.value).Sum();
    }
}
