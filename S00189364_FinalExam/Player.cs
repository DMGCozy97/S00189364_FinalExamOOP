using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S00189364_FinalExam
{

    //creating enum
    public enum Position { Goalkeeper, Defender, Midfielder, Forward }
    class Player : IComparable<Player>
    {
        //Proporties
        public string FirstName { get; set; }
        public string Surname { get; set; }

        public Position PreferedPosition { get; set; }

        public DateTime DateOfBirth { get; set; }

        private int _age;
        private string preferedPosition;
        private DateTime randomDate;
        private Player player;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        //Constructors

        //public Player(string firstName, string surname, Position preferedPosition, DateTime dateOfBirth, int age)
        //{
        //    this.FirstName = firstName;
        //    this.Surname = surname;
        //    this.PreferedPosition = preferedPosition;
        //    this.DateOfBirth = dateOfBirth;
        //    this.Age = age;
        //}

        public Player(string firstname, string surname, string preferedPosition, DateTime randomDate, int age)
        {
            FirstName = firstname;
            Surname = surname;
            this.preferedPosition = preferedPosition;
            this.randomDate = randomDate;
            Age = age;
        }

        public Player(Player player)
        {
            this.player = player;
        }

        //METHODS
        public override string ToString()
        {
            return $"{FirstName} {Surname} {PreferedPosition} on {DateOfBirth.ToShortDateString()}";
        }

        public int CompareTo(Player other)
        {
            return this.PreferedPosition.CompareTo(other.PreferedPosition);
        }


    }
}
