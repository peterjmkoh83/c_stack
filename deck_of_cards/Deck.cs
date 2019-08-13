using System;
using System.Collections.Generic;

namespace deck_of_cards
{
   class Deck
   {
      private Card[] deck;
      private int currentCard;
      private int number_of_cards = 52;
      private Random rand;
      public List<Card> Cards;

      public Deck()
      {
         this.Cards = new List<Card>();
         // this.Reset();
      }

      public void Reset(){
         this.Cards = new List<Card>();
         string[] suits = {"Clubs","Spades","Hearts","Diamonds"};
         string[] stringVal = {"Ace","Two","Three","Four","Five","Six","Seven","Eight","Nine","Ten","Jack","Queen","King"};
         
         int num = 0;
         foreach(string suit in suits){
            foreach(string val in stringVal){
               Card card = new Card(val, suit, num++);
               this.Cards.Add(card);
               System.Console.WriteLine(card);
            }
         }
      }
      
      





   }
}