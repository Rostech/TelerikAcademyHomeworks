using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using Santase.Logic.Cards;
using NUnit.Framework;
using System.Collections.Generic;

namespace SantaseGameEngine.Tests
{
    [TestFixture]
    public class DeckTests
    {
        [Test]
        [ExpectedException]
        public void ThrowExceptionOnGettingNextCartOnEmptyDeck()
        {
            Deck deck = new Deck();

            for (int i = 0; i <= 24; i++)
            {
                deck.GetNextCard();
            }
        }

        [Test]
        public void ChangingTrumpCardShouldNotThrow()
        {
            Deck deck = new Deck();
            Card trumpCard = deck.GetTrumpCard;
            Card newCard = new Card(CardSuit.Heart, CardType.Nine);
            deck.ChangeTrumpCard(newCard);
        }

        [TestCase(2)]
        [TestCase(6)]
        [TestCase(9)]
        [TestCase(18)]
        [TestCase(21)]
        public void ReturningRightAmountOfCards(int count)
        {
            Deck deck = new Deck();
            List<Card> cards = new List<Card>();

            for (int i = 0; i < count; i++)
            {
                cards.Add(deck.GetNextCard());
            }

            Assert.AreEqual(count, cards.Count);
        }
    }
}
