using System.Collections.Generic;
using System;

namespace DeckOfCards
{
    public class Card
    {
        private string Face { get; set; }
        private string Suit { get; set; }
        private int val {get; set;}



    public Card(string CardFace ,string CardSuit,int Val)
    {
        Face = CardFace;
        Suit = CardSuit;
        val =Val;
    }




    public override string ToString(){
        return Suit + " of " + Face;
    }


    }
}
    // public GroceryStore(string name)
    //     {
    //         Name = name;
    //         _products = new List<Product>
    //         {
    //             new Product("Milk", 4.99m),
    //             new Product("Royal Jelly", 10.95m),
    //             new Product("Healing Crystal", 66.6m),
    //             new Product("Cactus Jerkey", 5.95m),
    //             new Product("Fruit Flavored Fruitless Chews", 1.50m),
    //         };
    //     }