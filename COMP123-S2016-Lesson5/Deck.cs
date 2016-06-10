using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lesson5
{
    /**
    * <summary>
    * This class extends the List<Card> generic type
    * </summary>
    * 
    * @class Deck
    */
    public class Deck : List<Card>
    {
        // CONSTRUCTOR ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
        * <summary>
        * This is the default constructor for the Deck class
        * </summary>
        * 
        * @construtor Deck
        */
        public Deck()
        {
            this._create();
        }

        // PRIVATE METHODS+++++++++++++++++++++++++++++++++++
        /**
        * <summary>
        * This method creates a deck of cards
        * </summary>
        * 
        * @method _create
        * @return {void}
        */
        private void _create()
        {

            foreach (Suits suit in Enum.GetValues(typeof(Suits)))
            {

                foreach (Faces face in Enum.GetValues(typeof(Faces)))
                {
                    this.Add(new Card(face, suit)); // anonomys Card object to the list
                }

            }
        } // end CreateDeck method


        // PUBLIC METHODS ++++++++++++++++++++++++++++++++++++++++++

        /**
        * <summary>
        * This method displays a List of Card objects to the Console
        * </summary>
        * 
        * @method Display
        * @return {void}
        */
        public void Display()
        {
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+ Current Deck                              +");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++");

            foreach (Card card in this)
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
       * @method Shuffle
       * @return {void}
       */
        public void Shuffle()
        {
            // creates a psedo-random number sequence and stores it is random
            Random random = new Random();
            // record the number of cards in the deck list
            int cardCount = this.Count;

            // iterate through the list of cards
            for (int currentCard = 0; currentCard < cardCount; currentCard++)
            {
                Card tempCard = this[currentCard]; // copy current card to temp location
                int randomCard = random.Next(0, cardCount); // get a random card index
                this[currentCard] = this[randomCard]; // copy value from randomCard to current card
                this[randomCard] = tempCard; // copy current card to random card
            }
        }

         /**
       * <summary>
       * This method removes the 0th item from deck and return it to the caller
       * </summary>
       * 
       * @method Deal
       * @return {Card}
       *
       */
        public Card Deal()
        {
            Card returnedCard = this[0]; // copy the 0th card in the stack to the returnedCard

            // check to see if the deck is not empty
            if (this.Count>0)
            {
                this.RemoveAt(0); // removes the 0th Card from deck
            }
            

            return returnedCard;             
        }
    }  
}
