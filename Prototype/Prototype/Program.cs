using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
        class Transport
        {
            public string name { get; set; }
            public string size { get; set; }
            public int price { get; set; }
            public string engine { get; set; }
        public Transport Copy()
            {
                return (Transport)this.MemberwiseClone();
            }

            public Transport DeepCopy()
            {
                Transport clone = (Transport)this.MemberwiseClone();
                clone.engine = String.Copy(engine);
                clone.name = String.Copy(name);

                return clone;
            }
        }

    class Ship : Transport
    {
        private string engine;
        public Ship(string e) { engine = e; }
        
    }
    class Car : Transport
    {
        private string engine;
        public Car(string e) { engine = e; }
        public void ShowEn()
        {
            engine = "дизельные";
            Console.WriteLine(engine);
        }

    }
    class Plane : Transport
    {
        private string engine;
        public Plane(string e) { engine = e; }
        public void ShowEn()
        {
            engine = "Авиационный двигатель";
            Console.WriteLine(engine);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Transport p1 = new Transport();
            p1.name = "Ship1";
            p1.size = "50 metrs";
            p1.price = 400000;
            p1.engine = "паровые турбины";

            Transport p2 = p1.Copy();
            Transport p3 = p1.DeepCopy();

            Console.WriteLine("Original values of p1, p2, p3:");
            Console.WriteLine("   p1 instance values: ");
            DisplayValues(p1);
            Console.WriteLine("   p2 instance values:");
            DisplayValues(p2);
            Console.WriteLine("   p3 instance values:");
            DisplayValues(p3);

            p1.size = "100 m";
            p1.price = 96000;
            p1.engine = "газотурбинные двигатели";
            Console.WriteLine("\nValues of p1, p2 and p3 after changes to p1:");
            Console.WriteLine("   p1 instance values: ");
            DisplayValues(p1);
            Console.WriteLine("   p2 instance values (reference values have changed):");
            DisplayValues(p2);
            Console.WriteLine("   p3 instance values (everything was kept the same):");
            DisplayValues(p3);

        }

        public static void DisplayValues(Transport p)
        {
            Console.WriteLine("      Name: {0:s}, Size: {1:d}, Price: {2:d}, Engine: {3:s}",
                p.name, p.size, p.price, p.engine);
        }
    }
  }
