namespace dominos
{
    public interface ITrain
    {
        public List<Domino> dominos { get; }

        public bool AddDomino(Domino domino);

        public bool IsValidMove(Domino domino);
    }

    public class Train : ITrain
    {
        private static Domino TRAIN_STATION_DOMINO = new Domino(6, 6);

        public List<Domino> dominos { get; } = new() { TRAIN_STATION_DOMINO };

        public bool AddDomino(Domino domino)
        {
            if (!IsValidMove(domino))
                return false;

            dominos.Add(domino);
            return true;
        }

        public bool IsValidMove(Domino domino)
            => dominos.Last().value.Intersect(domino.value).Count() > 0;
    }
}
