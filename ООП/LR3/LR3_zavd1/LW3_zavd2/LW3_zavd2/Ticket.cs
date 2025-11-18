using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LW4_zavd2;
namespace LR1_Zavd3
{
    public class Ticket
    {


        //--------Властивості----------
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Attraction NameAttraction { get; set; }
        public int Age { get; set; }
        public DateTime DateTime { get; set; }
        //--------Конструктори----------
        public Ticket() // конструктор за замовчуванням
        {
            FirstName = "Назар";
            LastName = "Шейкін";
            NameAttraction = null;
            Age = 18;
            DateTime = new DateTime(2000, 4, 1, 0, 0, 0); 
        }
        public Ticket(string firstName, string lastName, Attraction nameAttraction, int year, DateTime dateTime) // з параметрами
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
       

        //--------Перевантаження----------

        // == і != (порівняння по всіх полях)
        public static bool operator ==(Ticket t1, Ticket t2)
        {
            if (ReferenceEquals(t1, t2)) return true;
            if ((object)t1 == null || (object)t2 == null) return false;

            return t1.FirstName == t2.FirstName &&
                   t1.LastName == t2.LastName &&
                   t1.NameAttraction == t2.NameAttraction &&
                   t1.Age == t2.Age &&
                   t1.DateTime == t2.DateTime;
        }
        public static bool operator !=(Ticket t1, Ticket t2) => !(t1 == t2);

        // > і < (порівняння за віком)
        public static bool operator >(Ticket t1, Ticket t2) => t1.Age > t2.Age;
        public static bool operator <(Ticket t1, Ticket t2) => t1.Age < t2.Age;

        // Додавання (зміщення дати на кілька днів)
        public static Ticket operator +(Ticket t, int days)
        {
            return new Ticket(t.FirstName, t.LastName, t.NameAttraction, t.Age, t.DateTime.AddDays(days));
        }

        // ToString() для гарного виводу
        public override string ToString()
        {
            return $"{FirstName} {LastName}, {Age} років, Атракціон: {NameAttraction}, Дата: {DateTime}";
        }

        // Щоб не сварився компілятор, треба перевизначити Equals і GetHashCode
        public override bool Equals(object obj)
        {
            if (obj is Ticket other) return this == other;
            return false;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(FirstName, LastName, NameAttraction, Age, DateTime);
        }
        public void Init(string name, string surname, Attraction selectAtt, int year, DateTime date, TimeSpan time)
        {
            FirstName = name;
            LastName = surname;
            NameAttraction = selectAtt;
            Age = year;
            DateTime = date.Add(time); 
        }
    }

    interface ITicket {

        void Init(string name, string surname, Attraction selectAtt, int year, string date, TimeSpan time);
    }

}
