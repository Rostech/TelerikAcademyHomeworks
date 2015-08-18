namespace PokerHandsChecker_IsFourOfAKindTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Poker;
    using System.Collections.Generic;

    [TestClass]
    public class PokerHandsChecker_IsFourOfAKindTest
    {
        [TestMethod]
        public void ExpectIsFourOfAKindToReturnTrueWhenThereIsFourOfAKindCombination()
        {
            List<ICard> cards = new List<ICard>();
            cards.Add(new Card(CardFace.Ace, CardSuit.Clubs));
            cards.Add(new Card(CardFace.Ace, CardSuit.Diamonds));
            cards.Add(new Card(CardFace.Ace, CardSuit.Hearts));
            cards.Add(new Card(CardFace.Ace, CardSuit.Spades));
            cards.Add(new Card(CardFace.Queen, CardSuit.Clubs));

            Hand hand = new Hand(cards);
            PokerHandsChecker checker = new PokerHandsChecker();
            Assert.AreEqual(true, checker.IsFourOfAKind(hand));
        }

        [TestMethod]
        public void ExpectIsFourOfAKindToReturnTrueWhenThereIsFourOfAKindCombinationTest2()
        {
            List<ICard> cards = new List<ICard>();
            cards.Add(new Card(CardFace.Two, CardSuit.Clubs));
            cards.Add(new Card(CardFace.Ace, CardSuit.Diamonds));
            cards.Add(new Card(CardFace.Two, CardSuit.Hearts));
            cards.Add(new Card(CardFace.Two, CardSuit.Spades));
            cards.Add(new Card(CardFace.Two, CardSuit.Diamonds));

            Hand hand = new Hand(cards);
            PokerHandsChecker checker = new PokerHandsChecker();
            Assert.AreEqual(true, checker.IsFourOfAKind(hand));
        }

        [TestMethod]
        public void ExpectIsFourOfAKindToReturnTrueWhenThereIsFourOfAKindCombinationTest3()
        {
            List<ICard> cards = new List<ICard>();
            cards.Add(new Card(CardFace.Two, CardSuit.Clubs));
            cards.Add(new Card(CardFace.Two, CardSuit.Hearts));
            cards.Add(new Card(CardFace.Ace, CardSuit.Diamonds));
            cards.Add(new Card(CardFace.Two, CardSuit.Spades));
            cards.Add(new Card(CardFace.Two, CardSuit.Diamonds));

            Hand hand = new Hand(cards);
            PokerHandsChecker checker = new PokerHandsChecker();
            Assert.AreEqual(true, checker.IsFourOfAKind(hand));
        }

        [TestMethod]
        public void ExpectIsFourOfAKindToReturnTrueWhenThereIsFourOfAKindCombinationTest4()
        {
            List<ICard> cards = new List<ICard>();
            cards.Add(new Card(CardFace.Ace, CardSuit.Diamonds));
            cards.Add(new Card(CardFace.Two, CardSuit.Clubs));
            cards.Add(new Card(CardFace.Two, CardSuit.Hearts));
            cards.Add(new Card(CardFace.Two, CardSuit.Spades));
            cards.Add(new Card(CardFace.Two, CardSuit.Diamonds));

            Hand hand = new Hand(cards);
            PokerHandsChecker checker = new PokerHandsChecker();
            Assert.AreEqual(true, checker.IsFourOfAKind(hand));
        }

        [TestMethod]
        public void ExpectIsFourOfAKindToReturnFalseWhenThereIsNotFourOfAKindCombination()
        {
            List<ICard> cards = new List<ICard>();
            cards.Add(new Card(CardFace.Two, CardSuit.Clubs));
            cards.Add(new Card(CardFace.Three, CardSuit.Diamonds));
            cards.Add(new Card(CardFace.Four, CardSuit.Hearts));
            cards.Add(new Card(CardFace.Ace, CardSuit.Spades));
            cards.Add(new Card(CardFace.Queen, CardSuit.Clubs));

            Hand hand = new Hand(cards);
            PokerHandsChecker checker = new PokerHandsChecker();
            Assert.AreEqual(false, checker.IsFourOfAKind(hand));
        }
    }
}
