using System;

namespace PickRandomCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of cards to pick: ");

            string line = Console.ReadLine();

            int numberOfCards;
            if (int.TryParse(line, out numberOfCards))
            {
                string[] pickedCards = CardPicker.PickSomeCards(numberOfCards);
                foreach (string card in pickedCards)
                {
                    Console.WriteLine(card);
                }

            }
            else 
            {
                Console.WriteLine("You have entered invalid number, please try again.");
            }
        }
    }
}
