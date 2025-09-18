using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1_Zavd3
{
    internal class Ticket
    {
        //--------Поля----------
        
        private string firstName_;
        private string lastName_;
        private string nameAttraction_;
        private int year_=0;

        //--------Властивості----------
        public string firstName
        {
            get { return firstName_; }
            set { firstName_ = value; }
        }
        public string lasttName
        {
            get { return lastName_; }
            set { lastName_ = value; }
        }
        public string nameAttraction
        {
            get { return nameAttraction_; }
            set { nameAttraction_ = value; }
        }
        public int year
        {
            get { return year_; }
            set { year_ = value; }
        }

        //--------Конструктори----------
        public Ticket() // конструктор за замовчуванням
        {
            firstName_ = "Unknown";
            lastName_ = "Unknown";
            nameAttraction_ = "Unknown";
            year_ = 0;
        }
        public Ticket(string firstName, string lastName, string nameAttraction, int year) // з параметрами
        {
            firstName_ = firstName;
            lastName_ = lastName;
            nameAttraction_ = nameAttraction;
            year_ = year;
        }
        public Ticket(Ticket other) // конструктор копіювання
        {
            firstName_ = other.firstName_;
            lastName_ = other.lastName_;
            nameAttraction_ = other.nameAttraction_;
            year_ = other.year_;
        }
        //--------Методи----------
    }
}
