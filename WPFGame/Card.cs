using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFGame
{
    public class Card
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Func<string> Func1;

        public override string ToString() 
        { 
            return String.Format("Person: {0}, Age: {1}, Message: {2}", this.Name, this.Age, this.Func1()); 
        }
    }
}
