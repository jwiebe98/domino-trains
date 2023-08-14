using dominos;
using static dominos.Board;

const int NUMBER_OF_DOMINOS_TO_DEAL = 20;

Domino[] availableDominos = new Domino[27] { 
    new(0, 0), new(0, 1), new(0, 2), new(0, 3), new(0, 4), new(0, 5), new(0, 6),
    new(1, 1), new(1, 2), new(1, 3), new(1, 4), new(1, 5), new(1, 6),
    new(2, 2), new(2, 3), new(2, 4), new(2, 5), new(2, 6),
    new(3, 3), new(3, 4), new(3, 5), new(3, 6),
    new(4, 4), new(4, 5), new(4, 6),
    new(5, 5), new(5, 6)
};

List<Domino> selectedDominos = GetRandomDominos(availableDominos);

Board board = new();

var playerOne = new Player()
{
    hand = DealOutDominos(selectedDominos, 0, 2)
};

var playerTwo = new Player()
{
    hand = DealOutDominos(selectedDominos, 1, 2)
};

while(playerOne.HasAnyMoves(board) || playerTwo.HasAnyMoves(board))
{
    foreach(Domino domino in playerOne.hand)
    {
        if (board.PlayDomino(playerOne, Direction.North, domino))
        {
            break;
        }
        if (board.PlayDomino(playerOne, Direction.South, domino))
        {
            break;
        }
        if (board.PlayDomino(playerOne, Direction.East, domino))
        {
            break;
        }
        if (board.PlayDomino(playerOne, Direction.West, domino))
        {
            break;
        }
    }

    if (playerOne.GetScore() == 0)
        break;

    foreach (Domino domino in playerTwo.hand)
    {
        if (board.PlayDomino(playerTwo, Direction.North, domino))
        {
            break;
        }
        if (board.PlayDomino(playerTwo, Direction.South, domino))
        {
            break;
        }
        if (board.PlayDomino(playerTwo, Direction.East, domino))
        {
            break;
        }
        if (board.PlayDomino(playerTwo, Direction.West, domino))
        {
            break;
        }
    }

    if (playerTwo.GetScore() == 0)
        break;
}

Console.WriteLine("Final Score:");
Console.WriteLine($"Player 1: {playerOne.GetScore()}");
Console.WriteLine($"Player 2: {playerTwo.GetScore()}");

if (playerOne.GetScore() < playerTwo.GetScore())
{
    Console.WriteLine($"Player 1 Wins!");
}
else if (playerOne.GetScore() > playerTwo.GetScore())
{
    Console.WriteLine($"Player 2 Wins!");
}
else
{
    Console.WriteLine("It's a Tie!");
}

List<Domino> GetRandomDominos(Domino[] dominos)
{
    List<Domino> dealtDominos = new();
    while (dealtDominos.Count < NUMBER_OF_DOMINOS_TO_DEAL)
    {
        Random rnd = new Random();

        var domino = dominos[rnd.Next(dominos.Count())];

        if (dealtDominos.Contains(domino))
            continue;
        
        dealtDominos.Add(domino);       
    }
    return dealtDominos;
}

List<Domino> DealOutDominos(List<Domino> selectedDominos, int player, int numberOfPlayers)
    => selectedDominos.Where((domino, i) => i % numberOfPlayers == player).ToList();













