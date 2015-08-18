namespace IsFlushTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Poker;
    using System.Collections.Generic;

    [TestClass]
    public class PokerHandsChecker_IsFlushTest
    {
        private PokerHandsChecker pokerHandsChecker = new PokerHandsChecker();
        Hand moreCardsHand = new Hand(new List<ICard>{new Card(CardFace.Two,CardSuit.Clubs),
            new Card(CardFace.Three,CardSuit.Clubs),
            new Card(CardFace.Four,CardSuit.Clubs),
            new Card(CardFace.Five,CardSuit.Clubs),
            new Card(CardFace.Four,CardSuit.Clubs),});

        Hand lessCardsHand = new Hand(new List<ICard>{new Card(CardFace.Two,CardSuit.Clubs),
            new Card(CardFace.Three,CardSuit.Clubs),
            new Card(CardFace.Four,CardSuit.Clubs)});

        Hand flushHand = new Hand(new List<ICard>{new Card(CardFace.Two,CardSuit.Clubs),
            new Card(CardFace.Three,CardSuit.Clubs),
            new Card(CardFace.Four,CardSuit.Clubs),
            new Card(CardFace.Five,CardSuit.Clubs),
        new Card(CardFace.Six,CardSuit.Clubs)});

        Hand notFlushHand = new Hand(new List<ICard>{new Card(CardFace.Eight,CardSuit.Diamonds),
            new Card(CardFace.King,CardSuit.Clubs),
            new Card(CardFace.Queen,CardSuit.Hearts),
            new Card(CardFace.Ten,CardSuit.Spades)});

        [TestMethod]
        public void IsFlushShouldReturnFalseIfHandIsNotAFlush()
        {
            Assert.IsFalse(this.pokerHandsChecker.IsFlush(notFlushHand));
        }

        [TestMethod]
        public void IsFlushShouldReturnTrueIfHandIsAFlush()
        {
            Assert.IsTrue(this.pokerHandsChecker.IsFlush(flushHand));
        }

        [TestMethod]
        public void IsFlushShouldReturnFalseIfHandIsWithLessCards()
        {
            Assert.IsFalse(this.pokerHandsChecker.IsFlush(lessCardsHand));
        }

        [TestMethod]
        public void IsFlushShouldReturnFalseIfHandIsWithMoreCards()
        {
            Assert.IsFalse(this.pokerHandsChecker.IsFlush(moreCardsHand));
        }
    }
}
