using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW4_zavd2
{
    public class Attraction
    {
        // Додаткові властивості, характерні для атракціонів
        public Image Image { get; set; }
        public string NameAttraction { get; set; } // назва атракціону
        public int DurationMinutes { get; set; }  // тривалість поїздки
        public int MinAge { get; set; }
        public double Price { get; set; }         // вартість квитка

        // Конструктор за замовчуванням
        public Attraction()
        {
            NameAttraction = "Generic Attraction";
            DurationMinutes = 5;
            Price = 150.0;
        }

        // Конструктор з параметрами
        public Attraction(Image image,string NameAttraction, int duration, int age, double price)
        {
            Image = image;
            this.NameAttraction = NameAttraction;
            DurationMinutes = duration;
            MinAge = age;
            Price = price;
        }

        public virtual string GetInfo()
        {
            return $"{NameAttraction}\nЦіна: {Price} грн\nМін. вік: {MinAge} років\nТривалість: {DurationMinutes} хв";
        }
        public virtual Image GetImage() => Image;
    }

    // ======= Похідні класи атракціонів =======

    public class RollerCoaster : Attraction
    {
        public double MaxSpeed { get; set; }

        public RollerCoaster() : base(Image.FromFile("D:\\VisualStudio\\ООП\\LR4\\LW4_zavd2\\img\\roller_coester.jpg"), "Roller Coaster", 200, 12, 150)
        {
           
            MaxSpeed = 120.0;
        }

        public RollerCoaster(string NameAttraction, int age, double maxSpeed,Image image)
            : base(image,NameAttraction, 200, age, 15)
        {
            MaxSpeed = maxSpeed;
        }
        public override string GetInfo()
        {
            return base.GetInfo() + $"\nМакс. швидкість: {MaxSpeed} км/год";
        }


    }
    
    public class FreefallTower : Attraction
    {
        public double Height { get; set; }

        public FreefallTower() : base(Image.FromFile("D:\\VisualStudio\\ООП\\LR4\\LW4_zavd2\\img\\freefall.jpg"), "Freefall Tower", 5, 18, 250)
        {
            Height = 50.0;
        }

        public FreefallTower(int age, double height,Image image)
            : base(image,"Freefall Tower", 180, age, 2)
        {
            Height = height;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $"\nВисота: {Height} м";
        }
    }

    public class FerrisWheel : Attraction
    {
        public int CabinsCount { get; set; }

        public FerrisWheel() : base(Image.FromFile("D:\\VisualStudio\\ООП\\LR4\\LW4_zavd2\\img\\wheel.jpg"), "Ferris Wheel", 5, 18, 250)
        {
            NameAttraction = "Ferris Wheel";
            CabinsCount = 30;
        }

        public FerrisWheel(int age, int cabins,Image image)
            : base(image,"Ferris Wheel", 100, age, 10)
        {
            CabinsCount = cabins;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $"\nКількість кабінок: {CabinsCount} км/год";
        }
    }
    // ==================Інтерфейс========================
    interface IAttraction
    {
        string GetInfo(); // повертає текст з інформацією
        Image GetImage(); // повертає зображення
    }

}

