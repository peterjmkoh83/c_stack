using System;
using System.Collections.Generic;

namespace deck_of_cards
{
// Give the Card class a property "stringVal" which will hold the value of the card ex. (Ace, 2, 3, 4, 5, 6, 7, 8, 9, 10, Jack, Queen, King). This "val" should be a string.
// Give the Card a property "suit" which will hold the suit of the card (Clubs, Spades, Hearts, Diamonds).
// Give the Card a property "val" which will hold the numerical value of the card 1-13 as integers.

    class Card
    {
        public string StringVal;
        public string Suit;
        public int IntVal;

        public Card(string stringVal, string suit, int intVal)
        {
            StringVal = stringVal;
            Suit = suit;
            IntVal = intVal;
        }

    }    






}