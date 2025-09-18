using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1_Zavd3
{
    internal class Ticket
    {
        //Test2


        //--------Властивості----------
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NameAttraction { get; set; }
        public int Age { get; set; }
        public DateTime DateTime { get; set; }
        //--------Конструктори----------
        public Ticket() // конструктор за замовчуванням
        {
            FirstName = "Назар";
            LastName = "Шейкін";
            NameAttraction = "Freefall tower";
            Age = 18;
            DateTime = new DateTime(2000, 4, 1, 0, 0, 0); 
        }
        public Ticket(string firstName, string lastName, string nameAttraction, int year, DateTime dateTime) // з параметрами
        {
            FirstName = firstName;
            LastName = lastName;
            NameAttraction = nameAttraction;
            Age = year;
            DateTime= dateTime;
        }
        public Ticket(Ticket other) // конструктор копіювання
        {
            FirstName = other.FirstName;
            LastName = other.LastName;
            NameAttraction = other.NameAttraction;
            Age = other.Age;
            DateTime= other.DateTime;
        }
        //--------Методи----------
    }
}
