using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P03.Cards
{
    class Program
    {
        public class Card
        {
            public Card(string face, string suit)
            {
                Face = face;
                Suit = suit;
            }

            public string Face { get; set; }
            public string Suit { get; set; }

            public override string ToString()
            {
                return $"[{this.Face}{this.Suit}]";
            }
        }


        static void Main()
        {
            List<Card> cardsList = new List<Card>();
            string[] inData = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            for (int i = 0; i < inData.Length; i++)
            {
                try
                {
                    string[] data = inData[i]
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                    string face = data[0];
                    string suit = data[1];
                    Card newCard = CreateCard(face, suit);
                    cardsList.Add(newCard);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }

            foreach (var item in cardsList)
            {
                char ch = char.Parse(item.Suit);
                Console.Write($"[{item.Face}{ch}] ");
            }
        }


        public static Card CreateCard(string face, string suit)
        {
            List<string> faseList = new List<string>() { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

            Dictionary<string, string> suitDict = new Dictionary<string, string>()
           {
               { "S", "\u2660"},
               { "H", "\u2665"},
               {"D", "\u2666" },
               { "C", "\u2663"}
           };

            if (faseList.Contains(face) && suitDict.ContainsKey(suit))
            {
                string newSuit = suitDict[suit];
                Card currCard = new Card(face, newSuit);
                return currCard;
            }
            else
            {
                throw new ArgumentException("Invalid card!");
            }
        }
    }
}
