using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFGame
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            List<Card> cards = new List<Card>();

            cards.Add(new Card
            {
                Name = "Mrs. Frederic",
                Age = 120,
                Func1 = Method1
            });

            cards.Add(new Card
            {
                Name = "Claudia Donovan",
                Age = 19,
                Func1 = Method2
            });

            cards.Add(new Card
            {
                Name = "Arthur Nielsen",
                Age = 45,
                Func1 = Method3
            });

            lbl1.Content = cards[0].ToString();
            lbl2.Content = cards[1].ToString();
            lbl3.Content = cards[2].ToString();
        }

        public string Method1() { return "This is method 1. Apples."; }
        public string Method2() { return "And this is method 2. Oranges."; }
        public string Method3() { return "Yeah, something here too."; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LabyrinthGameEngine engine = new LabyrinthGameEngine();
            lbl21.Content = "Default value for property 1: " + engine.OneString;
            lbl22.Content = "Default value for property 2: " + engine.SomeInteger;
            lbl23.Content = "Executing a function on card 1: " + engine.Cards[0].Func1();
            lbl24.Content = "Calling a function without parentheses, just getting a function signature: " + engine.Cards[1].Func1;
            lbl25.Content = "Changed value for property 1: " + engine.OneString;
            lbl26.Content = "Still a default value for property 2 because Func2 was not called properly" + engine.SomeInteger;
        }
    }
}
