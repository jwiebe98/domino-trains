namespace dominos
{
    public interface IDomino
    {
        public int[] value { get; }
    }

    public class Domino : IDomino
    {
        private const int NUMBER_OF_SIDES = 2;

        public Domino(int top, int bottom)
        {
            value = new int[NUMBER_OF_SIDES] { top, bottom };
        }
        public int[] value { get; }
    }
}
