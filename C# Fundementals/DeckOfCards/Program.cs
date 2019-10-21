using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Deck testDeck = new Deck();
            System.Console.WriteLine(testDeck);
            System.Console.WriteLine(testDeck.mycards);
            System.Console.WriteLine(testDeck.Deal());
            System.Console.WriteLine(testDeck.Reset());
            System.Console.WriteLine(testDeck.Reset());
            Players player1 = new Players("nate");
            Console.WriteLine(player1);
            player1.Draw(testDeck);
            System.Console.WriteLine(player1.Draw(testDeck));
        }
    }
}
