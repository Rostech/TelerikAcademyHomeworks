namespace CardTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Poker;
    using System.Collections.Generic;

    [TestClass]
    public class HandTesting
    {
        Hand hand = new Hand(new List<ICard>{new Card(CardFace.Eight,CardSuit.Diamonds),
            new Card(CardFace.King,CardSuit.Clubs),
            new Card(CardFace.Queen,CardSuit.Hearts),
            new Card(CardFace.Ten,CardSuit.Spades)});

        [TestMethod]
        public void ToStringMustReturnAllCardsInTheHandSeparated()
        {
            Assert.AreEqual("8♦, K♠, Q♥, 10♣", this.hand.ToString(), "The String method should return all cards in the hand separated with , ");
        }
    }
}
