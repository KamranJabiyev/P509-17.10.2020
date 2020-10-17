using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Casting
            #region upcasting,boxing,implicit
            //Eagle eagle = new Eagle();
            //Shark shark = new Shark();

            //Bird eagle1 = new Eagle();
            //Animal eagle2 = new Eagle();
            //Object eagle3 = new Eagle();

            //Animal shark1 = new Shark();
            //shark1.Eat();
            //ISee eagle4 = new Eagle();
            ////eagle4.See();
            //Console.WriteLine(eagle4);

            //Eagle eagle = new Eagle();
            //Shark shark = new Shark();
            //int x = 5;
            //char letter = 'a';
            //bool isMaried = true;
            //object[] arr = { eagle, shark, x, letter, isMaried };
            #endregion

            #region Downcasting,unboxing,explicit
            //Animal eagle = new Eagle();
            //Animal shark = new Shark();

            //insecurity way
            //Shark shark1 = (Shark)eagle;
            //shark1.Swim();

            //downcasting security way - 1
            //Animal[] animals = { eagle, shark };

            //foreach (Animal item in animals)
            //{
            //    if(item is Shark)
            //    {
            //        Shark shark1 = (Shark)item;
            //        shark1.Swim();
            //    }
            //    else
            //    {
            //        Console.WriteLine("Shark tipi deyil");
            //    }
            //}

            //downcasting security way - 2
            //foreach (Animal item in animals)
            //{
            //    Shark newShark = item as Shark;
            //    if (newShark != null)
            //    {
            //        newShark.Swim();
            //    }
            //    else
            //    {
            //        Console.WriteLine("Shark tipi deyil");
            //    }
            //}
            #endregion
            #endregion

            #region Implicit,explicit
            //Manat manat = new Manat { Azn=340};

            //Dollar dollar = (Dollar)manat;
            //Console.WriteLine(dollar.Usd);
            #endregion

            #region override operators in Custom type 
            //int a = 10;
            //int b = 5;
            //Console.WriteLine(a>b);
            Person p1 = new Person("Zaur","Necefli",25);
            Person p2 = new Person("Balakishi","Qurbanov",38);
            //Console.WriteLine(p2+p1);
            //Console.WriteLine(p1-p2);
            //Console.WriteLine(p1==p2);
            #endregion
        }
    }

    #region override operators in Custom type 
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public Person(string name,string surname,int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public static string operator +(Person p1,Person p2)
        {
            //return p1.Age + p2.Age;
            return $"{p1.Name} {p2.Surname}";
        }

        public static int operator -(Person p1,Person p2)
        {
            return p2.Age - p1.Age;
        }

        public static bool operator >(Person p1, Person p2)
        {
            return p1.Age > p2.Age;
        }

        public static bool operator <(Person p1, Person p2)
        {
            return p1.Age < p2.Age;
        }
    }
    #endregion

    #region Implicit,explicit
    class Manat
    {
        public double Azn { get; set; }

        //public static implicit operator Dollar(Manat manat)
        //{
        //    return new Dollar { Usd = manat.Azn / 1.7 };
        //}

        public static explicit operator Dollar(Manat manat)
        {
            return new Dollar { Usd = manat.Azn / 1.7 };
        }
    }

    class Dollar
    {
        public double Usd { get; set; }
    }
    #endregion

    #region Casting
    interface ISee
    {
        void See();
    }

    abstract class Animal
    {
        public abstract void Eat();
    }

    abstract class Bird:Animal
    {
        public abstract void Fly();
    }

    abstract class Fish : Animal
    {
        public abstract void Swim();
    }

    class Eagle : Bird,ISee
    {
        public int EagleAge { get; set; }
        public override void Eat()
        {
            Console.WriteLine("Eat as Eagle");
        }

        public override void Fly()
        {
            Console.WriteLine("Fly as Eagle");
        }

        public void See()
        {
            Console.WriteLine("See as Eagle");
        }
    }

    class Shark : Fish,ISee
    {
        public int TeethCount { get; set; }
        public override void Eat()
        {
            Console.WriteLine("Eat as Shark");
        }

        public void See()
        {
            Console.WriteLine("See as Shark");
        }

        public override void Swim()
        {
            Console.WriteLine("Swim as Shark");
        }
    }
    #endregion
}
