using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    public enum Position { Goalkeeper, Defender, Midfielder, Forward }

    class Player : IComparable
    {
        //properties
        public string FirstName { get; set; }

        public string SurName { get; set; }

        public Position PreferredPosition { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime Age { get; set; }


        //methods
        private string _spaces;

        public string Spaces
        {
            get
            {
                return string.Format("{0}  DateOfBirth - {1:C}", _spaces, Age);
            }
            set
            {
                _spaces = value;
            }
        }

        string[] firstNames = {
                "Adam", "Amelia", "Ava", "Chloe", "Conor", "Daniel", "Emily",
                "Emma", "Grace", "Hannah", "Harry", "Jack", "James",
                "Lucy", "Luke", "Mia", "Michael", "Noah", "Sean", "Sophie"};

        string[] lastNames = {
                "Brennan", "Byrne", "Daly", "Doyle", "Dunne", "Fitzgerald", "Kavanagh",
                "Kelly", "Lynch", "McCarthy", "McDonagh", "Murphy", "Nolan", "O'Brien",
                "O'Connor", "O'Neill", "O'Reilly", "O'Sullivan", "Ryan", "Walsh"};

        //constructors
        public int CompareTo(object obj)
        {
            Player that = obj as Player;
            return this.Age.CompareTo(that.DateOfBirth);
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", FirstName, Age.ToShortDateString());
        }
    }
}
