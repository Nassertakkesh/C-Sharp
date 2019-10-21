using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class Players
    {
        Deck thisDeck = new Deck();

        public string name {get; set;}
        public List <Card> hand {get; set;}
        

        public Players(string Name)
        {
            Name = name;
            hand = new List<Card>();

        }
        public Card Draw(Deck testDeck)
        {
            Random rand = new Random(52);
            
            Card theHand = testDeck.mycards[rand.Next(0,52)];
            hand.Add(theHand);
            return theHand;
        }
    }
}

// Give the Player class a name property.
// Give the Player a hand property that is a List of type Card.
// Give the Player a draw method of which draws a card from a deck, adds it to the player's hand and returns the Card.
// Note this method will require reference to a deck object
// Give the Player a discard method which discards the Card at the specified index from the player's hand and returns this Card or null if the index does not exist.