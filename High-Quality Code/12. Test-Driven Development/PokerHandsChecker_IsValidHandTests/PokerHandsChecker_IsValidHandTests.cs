namespace PokerHandsChecker_IsValidHandTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Poker;
    using System.Collections.Generic;

    [TestClass]
    public class PokerHandsChecker_IsValidHandTests
    {
        [TestMethod]
        public void ExpectIsValidToReturnTrueWhenPokeHandIsValid()
        {
            List<ICard> cards = new List<ICard>();
            cards.Add(new Card(CardFace.Ace, CardSuit.Clubs));
            cards.Add(new Card(CardFace.Ace, CardSuit.Diamonds));
            cards.Add(new Card(CardFace.Ace, CardSuit.Hearts));
            cards.Add(new Card(CardFace.Ace, CardSuit.Spades));
            cards.Add(new Card(CardFace.Queen, CardSuit.Clubs));

            Hand hand = new Hand(cards);
            PokerHandsChecker checker = new PokerHandsChecker();
            Assert.AreEqual(true, checker.IsValidHand(hand));
        }

        [TestMethod]
        public void ExpectIsValidToReturnFalseWhenPokeHandIsInvalidBecauseItHasLessThanFiveCards()
        {
            List<ICard> cards = new List<ICard>();
            cards.Add(new Card(CardFace.Ace, CardSuit.Clubs));
            cards.Add(new Card(CardFace.Ace, CardSuit.Diamonds));
            cards.Add(new Card(CardFace.Ace, CardSuit.Hearts));
            cards.Add(new Card(CardFace.Ace, CardSuit.Spades));

            Hand hand = new Hand(cards);
            PokerHandsChecker checker = new PokerHandsChecker();
            Assert.AreEqual(false, checker.IsValidHand(hand));
        }

        [TestMethod]
        public void ExpectIsValidToReturnFalseWhenPokeHandIsInvalidBecauseItHasRepetingCards()
        {
            List<ICard> cards = new List<ICard>();
            cards.Add(new Card(CardFace.Ace, CardSuit.Clubs));
            cards.Add(new Card(CardFace.Ace, CardSuit.Diamonds));
            cards.Add(new Card(CardFace.Ace, CardSuit.Hearts));
            cards.Add(new Card(CardFace.Ace, CardSuit.Spades));
            cards.Add(new Card(CardFace.Ace, CardSuit.Spades));

            Hand hand = new Hand(cards);
            PokerHandsChecker checker = new PokerHandsChecker();
            Assert.AreEqual(false, checker.IsValidHand(hand));
        }

        [TestMethod]
        public void ExpectIsValidToReturnFalseWhenPokeHandIsInvalidBecauseItHasMoreThanFiveCards()
        {
            List<ICard> cards = new List<ICard>();
            cards.Add(new Card(CardFace.Ace, CardSuit.Clubs));
            cards.Add(new Card(CardFace.Ace, CardSuit.Diamonds));
            cards.Add(new Card(CardFace.Ace, CardSuit.Hearts));
            cards.Add(new Card(CardFace.Ace, CardSuit.Spades));
            cards.Add(new Card(CardFace.Queen, CardSuit.Clubs));
            cards.Add(new Card(CardFace.Queen, CardSuit.Spades));

            Hand hand = new Hand(cards);
            PokerHandsChecker checker = new PokerHandsChecker();
            Assert.AreEqual(false, checker.IsValidHand(hand));
        }
    }
}
