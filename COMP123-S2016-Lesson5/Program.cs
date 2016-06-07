using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lesson5
{
    /**
     * This class is the "driver" class for our Program
     * 
     * @class Program
     */
    public class Program
    {
        /**
         * the main method for our driver class Program
         * 
         * @method Main
         * @param {sting[]} args
         */
        public static void Main(string[] args)
        {
            //create instance of the Student class

            List<Card> Deck = new List<Card>();

            CreateDeck(Deck);
            DisplayDeck(Deck); // display initial state

            ShuffleDeck(Deck);
            DisplayDeck(Deck);
        }


        /**
        * <summary>
        * This method creates a deck of cards
        * </summary>
        * 
        * @method CreateDeck
        * @param {List<Card>} deck
        * @return {void}
        */
        public static void CreateDeck(List<Card> deck)
        {
            string suit = "";

            for (int i = 0; i < 4; i++)
            {
                switch (i)
                {
                    case 0:
                        suit = "hearts";
                        break;
                    case 1:
                        suit = "clubs";
                        break;
                    case 2:
                        suit = "diamonds";
                        break;
                    case 3:
                        suit = "spades";
                        break;

                }
                for (int face = 1; face < 14; face++)
                {
                    deck.Add(new Card(face, suit));
                } //end for -face
            } // end for -suit
        } // end CreateDeck method


        /**
        * <summary>
        * This method displays a List of Card objects to the Console
        * </summary>
        * 
        * @method DisplayDeck
        * @param {List<Card>} deck
        * @return {void}
        */
        public static void DisplayDeck(List<Card> deck)
        {
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+ Current Deck                              +");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++");

            foreach (Card card in deck)
            {
                Console.WriteLine("{0} of {1}", card.Face, card.Suit);
            }
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
        }


        /**
       * <summary>
       * This method randomly shuffles a List of Card objects
       * </summary>
       * 
       * @method ShuffleDeck
       * @param {List<Card>} deck
       * @return {void}
       */
        public static void ShuffleDeck(List<Card> deck)
        {
            // creates a psedo-random number sequence and stores it is random
            Random random = new Random();
            // record the number of cards in the deck list
            int cardCount = deck.Count;

            // iterate through the list of cards
            for (int currentCard = 0; currentCard < cardCount; currentCard++)
            {
                Card tempCard = deck[currentCard]; // copy current card to temp location
                int randomCard = random.Next(0,cardCount); // get a random card index
                deck[currentCard] = deck[randomCard]; // copy value from randomCard to current card
                deck[randomCard] = tempCard; // copy current card to random card
            }
        }

    } // end Program

} // end namespace
