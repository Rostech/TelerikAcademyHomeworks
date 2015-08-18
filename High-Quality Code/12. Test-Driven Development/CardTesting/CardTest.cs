namespace CardTesting
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Poker;

    [TestClass]
    public class CardTest
    {
        [TestMethod]
        public void CardMethodToStringShouldNotThrowAnException()
        {
            Card card = new Card(CardFace.Ace, CardSuit.Diamonds);
            card.ToString();
        }

        [TestMethod]
        public void CardMethodToStringShouldReturnQueenOfHearts()
        {
            Card card = new Card(CardFace.Queen, CardSuit.Hearts);
            Assert.AreEqual("Q♥", card.ToString(), "Cart toString() method should return in this case: Q♥ .");
        }

        [TestMethod]
        public void CardMethodToStringShouldReturnTwoOfSpades()
        {
            Card card = new Card(CardFace.Two, CardSuit.Spades);
            Assert.AreEqual("2♣", card.ToString(), "Cart toString() method should return in this case: 2♣ .");
        }

        [TestMethod]
        public void CardMethodToStringShouldReturnSevenOfDiamonds()
        {
            Card card = new Card(CardFace.Seven, CardSuit.Diamonds);
            Assert.AreEqual("7♦", card.ToString(), "Cart toString() method should return in this case: 7♦ .");
        }

        [TestMethod]
        public void CardMethodToStringShouldReturnAceOfClubs()
        {
            Card card = new Card(CardFace.Ace, CardSuit.Clubs);
            Assert.AreEqual("A♠", card.ToString(), "Cart toString() method should return in this case: A♠ .");
        }
    }
}
