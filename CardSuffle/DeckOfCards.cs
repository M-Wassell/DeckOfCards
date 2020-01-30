using System;
using System.Collections.Generic;
using System.Text;

namespace CardSuffle
{
    class DeckOfCards
    {
        private readonly Card[] deck;
        private int currentCard;
        private const int NUMBER_OF_CARDS = 52;
        private readonly Random randomNumbers;

        public DeckOfCards()
        {
            string[] faces = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven"
                    , "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
            string[] suits = { "Hearts", "Clubs", "Dimands", "Spades" };

            deck = new Card[NUMBER_OF_CARDS];
            currentCard = 0;
            randomNumbers = new Random();

            // populate deck with card objects 
            for (int c = 0; c < deck.Length; ++c)
                deck[c] =
                    new Card(faces[c % 13], suits[c / 13]);
        }   

        // deal one card
        public Card DealCard()
        {

            if (currentCard < deck.Length)
                return deck[currentCard++];
            else

                return null;
        }

        
    }
}
