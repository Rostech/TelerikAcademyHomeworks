using System;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        private const int ValidHandCardsCount = 5;
        private const int FourOfAKindCount = 4;

        public bool IsValidHand(IHand hand)
        {
            if(hand.Cards.Count < ValidHandCardsCount || ValidHandCardsCount < hand.Cards.Count)
            {
                return false;
            }

            for(int i = 0; i < hand.Cards.Count - 1; i++)
            {
                for(int j = i+1; j < hand.Cards.Count; j++)
                {
                    if(hand.Cards[i].Face == hand.Cards[j].Face &&
                       hand.Cards[i].Suit == hand.Cards[j].Suit)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public bool IsStraightFlush(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFourOfAKind(IHand hand)
        {
            if(!IsValidHand(hand))
            {
                return false;
            }

            int equalCardFaceCount = 0;

            for (int i = 0; i < hand.Cards.Count - 1; i++)
            {
                for (int j = i + 1; j < hand.Cards.Count; j++)
                {
                    if (hand.Cards[i].Face == hand.Cards[j].Face)
                    {
                        equalCardFaceCount++;
                        if (equalCardFaceCount == FourOfAKindCount)
                        {
                            return true;
                        }
                    }
                }
            }           

            return false;
        }

        public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFlush(IHand hand)
        {
            if (!IsValidHand(hand))
            {
                return false;
            }

            if (hand.Cards.Count != 5)
            {
                return false;
            }

            for (int i = 0; i < 5; i++)
            {
                if (hand.ToString().IndexOf(hand.Cards[i].ToString()) != hand.ToString().LastIndexOf(hand.Cards[i].ToString()))
                {
                    return false;
                }
            }
            CardSuit cardsSuit = hand.Cards[0].Suit;

            for (int j = 0; j < 5; j++)
            {
                if (hand.Cards[j].Suit != cardsSuit)
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsStraight(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsTwoPair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsOnePair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsHighCard(IHand hand)
        {
            throw new NotImplementedException();
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }
    }
}
