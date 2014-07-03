using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFGame
{
    public class LabyrinthGameEngine
    {
        List<Card> cards;
        CardsProvider cardsProvider;

        //constructor:
        public LabyrinthGameEngine()
        {
            cardsProvider = new CardsProvider(this); //pass the resource of this class so you can reference it within CardsProvider
            cards = cardsProvider.GetAllCards();
            this.OneString = "default value";
            this.SomeInteger = -1;
        }

        //and some properties here for demonstration
        public string OneString { get; set; }
        public int SomeInteger { get; set; }
        public List<Card> Cards
        {
            get { return this.cards; }
        }
    }
}
