using System;

namespace CardSuffle
{
    class DeckOfCardsTest
    {
        static void Main(string[] args)
        {
            DeckOfCards myDeckOfCards = new DeckOfCards();

            for (int i = 0; i < 52; ++i)
            {
                Console.WriteLine( "{0, 10}", myDeckOfCards.DealCard());

                if ((i + 1) % 13 == 0)
                    Console.WriteLine();
            }

            
        }
    }
}
