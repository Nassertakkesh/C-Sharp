
using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class Deck
    {

public List <Card> mycards  = new List <Card>();

public List <string> faces = new List<string>  {"Ace", "one","two","three","four","five","six","seven","eight","nine","ten", "Jack", "Queen", "king" };
public List <string> Suits = new List<string> {"Hearts", "Clubs","Diamonds","Spades"};

private Random ranNum;

    public Deck()
    {
        List <Card> thisCard  = new List <Card>();

         int counter = 0;
                for (int i = 0; i < Suits.Count; i++)
                {
                    for (int j = 0; j < faces.Count; j++)
                    {
                        counter +=1;
                        Card newCard = new Card(Suits[i],faces[j],counter);
                        
                        mycards.Add(newCard);
                        thisCard.Add(newCard);
                    }
                }
    }
    public Card Deal()
    {
        Card theCard = mycards[(mycards.Count-1)];
        mycards.RemoveAt(mycards.Count-1);

        return theCard;
    }


    public Deck Reset()
    {
        Deck newDeck = new Deck();
        return newDeck;
    }



// Deck newDeck = new Deck();
//  static Random _random = new Random();
//      public Deck shuffle(newDeck)
//     {
//         int n = mycards.Count;
//         for (int i = 0; i < n; i++)
//         {
//             int r = i + _random.Next(n - i);
//             mycards [t] = mycards[r];
//             mycards[r] = mycards[i];
//             mycards[i] = t;
            
//         }
//         return Deck;
//     }


}
}

// Give the Deck class a property called "cards" which is a list of Card objects.
// When initializing the deck, make sure that it has a list of 52 unique cards as its "cards" property.
// Give the Deck a deal method that selects the "top-most" card, removes it from the list of cards, and returns the Card.
// Give the Deck a reset method that resets the cards property to contain the original 52 cards.
// Give the Deck a shuffle method that randomly reorders the deck's cards.

        // private Card[] deck;
// private int currentCard;
// private const int NUMBER_OF_CARDS = 52;

      
        // deck = new Cards[NUMBER_OF_CARDS];
        // currentCard = 0;
        // ranNum = new Random();
        // for (int i = 0; i < deck.Length; i++)
        // {
        //     deck[i] = new Cards(faces[i%11], suits [i/13]);
        // }