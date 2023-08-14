using dominos;

namespace dominos_test
{
    [TestClass]
    public class TrainTests
    {
        [TestMethod]
        public void Assert_TrainStartWith_1_Domino()
        {
            ITrain train = new Train();

            Assert.IsTrue(train.dominos.Count == 1, "A train must start with a length of 1");
        }

        [TestMethod]
        public void Assert_TrainDominosStartWith_6_6_Domino()
        {
            ITrain train = new Train();

            Assert.IsTrue(train.dominos[0].value[0] == 6 && train.dominos[0].value[1] == 6, "A train must start with train station domino");
        }

        [TestMethod]
        public void Assert_OnlyDominoWithValidNumberCanBeAdded()
        {
            ITrain train = new Train();

            train.AddDomino(new Domino(5, 6));

            Assert.IsTrue(train.dominos.Count == 2, "Train should have 2 dominos after adding one");
        }

        [TestMethod]
        public void Assert_DominoAddedIsAtEndOfList()
        {
            ITrain train = new Train();

            Domino domino = new Domino(5, 6);

            train.AddDomino(domino);

            Assert.IsTrue(train.dominos[1] == domino, "Last domino was not the last added one");
        }

        [TestMethod]
        public void Assert_DominoReturnsTrue()
        {
            ITrain train = new Train();            

            Assert.IsTrue(train.AddDomino(new Domino(5, 6)), "When a domino is added the AddDomino function must return true");
        }

        [TestMethod]
        public void Assert_InvalidDominoReturnsFalse()
        {
            ITrain train = new Train();

            Assert.IsTrue(!train.AddDomino(new Domino(5, 5)), "When an invalid domino is added the AddDomino function must return false");
        }

        [TestMethod]
        public void Assert_ValidMove()
        {
            ITrain train = new Train();

            Assert.IsTrue(train.IsValidMove(new Domino(6, 5)), "IsValidMove should return true for valid move");
        }

        [TestMethod]
        public void Assert_InValidMove()
        {
            ITrain train = new Train();

            Assert.IsTrue(!train.IsValidMove(new Domino(5, 5)), "IsValidMove should return false for invalid move");
        }
    }
}