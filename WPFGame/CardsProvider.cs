using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFGame
{
    public class CardsProvider
    {
        LabyrinthGameEngine eng; //reference to the game engine class

        public CardsProvider(LabyrinthGameEngine eng)
        {
            this.eng = eng;
        }

        //constructor
        public List<Card> GetAllCards()
        {
            List<Card> cards = new List<Card>();
            cards.Add(new Card { Name = "Card 1", Func1 = SetStringProperty });
            cards.Add(new Card { Name = "Card 2", Func1 = SetIntegerProperty });
            return cards;
        }

        //simple methods that imitate your actions
        public string SetStringProperty()
        {
            eng.OneString = "this string is no longer the default value";
            return "eng.OneString is set";
        }

        public string SetIntegerProperty()
        {
            eng.SomeInteger = 10;
            return "eng.SomeInteger is set";
        }
    }
}
