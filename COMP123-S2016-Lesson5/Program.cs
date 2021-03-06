﻿using System;
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
            Deck deck = new Deck(); // create a deck of cards
            deck.Display(); // siplay the initial deck

            deck.Shuffle(); // shuffle the deck
            deck.Display(); // display the deck after shuffling

            Card cardDealt = deck.Deal();
            Console.WriteLine("Card Delt: {0} of {1}", cardDealt.Face, cardDealt.Suit);
            Console.WriteLine();
            deck.Display();
        }
            
    } // end Program

} // end namespace
