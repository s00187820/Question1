using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    public enum Position { Goalkeeper, Defender, Midfielder, Forward }
    class Player
    {
        public string FirstName { get; set; }

        public string SurName { get; set; }

        public Position PreferredPosition { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime Age { get; set; }






    }
}
