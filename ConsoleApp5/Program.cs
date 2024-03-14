using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {

        class Human
        {
            protected string name;
            protected int age;
            protected string gender;

            public Human(string name, int age, string gender)
            {
                this.name = name;
                this.age = age;
                this.gender = gender;
            }

            public void Greet()
            {
                Console.WriteLine("Привет, меня зовут " + name + " и мне " + age + " лет.");
            }
        }

        class Builder : Human
        {
            private int experience;

            public Builder(string name, int age, string gender, int experience)
                : base(name, age, gender)
            {
                this.experience = experience;
            }

            public void Build()
            {
                Console.WriteLine("Я строитель " + name + " и я могу строить.");
            }
        }

        class Sailor : Human
        {
            public string shipName;

            public Sailor(string name, int age, string gender, string shipName)
                : base(name, age, gender)
            {
                this.shipName = shipName;
            }

            public void Sail()
            {
                Console.WriteLine("Я моряк " + name + " и я могу плавать на корабле " + shipName + ".");
            }
        }

        class Pilot : Human
        {
            private string aircraft;

            public Pilot(string name, int age, string gender, string aircraft)
                : base(name, age, gender)
            {
                this.aircraft = aircraft;
            }

            public void Fly()
            {
                Console.WriteLine("Я летчик " + name + " и я могу летать на самолете " + aircraft + ".");
            }
        }

        class Passport
        {
            protected string fullName;
            protected string passportNumber;
            protected DateTime issueDate;

            public Passport(string fullName, string passportNumber, DateTime issueDate)
            {
                this.fullName = fullName;
                this.passportNumber = passportNumber;
                this.issueDate = issueDate;
            }

            public virtual void DisplayInfo()
            {
                Console.WriteLine("Паспортные данные:");
                Console.WriteLine("ФИО: " + fullName);
                Console.WriteLine("Номер паспорта: " + passportNumber);
                Console.WriteLine("Дата выдачи: " + issueDate.ToString("yyyy-MM-dd"));
            }
        }

        class ForeignPassport : Passport
        {
            private string passportNumberForeign;
            private string[] visas;

            public ForeignPassport(string fullName, string passportNumber, DateTime issueDate, string passportNumberForeign, string[] visas)
                : base(fullName, passportNumber, issueDate)
            {
                this.passportNumberForeign = passportNumberForeign;
                this.visas = visas;
            }

            public override void DisplayInfo()
            {
                base.DisplayInfo();
                Console.WriteLine("Заграничные паспортные данные:");
                Console.WriteLine("Номер заграничного паспорта: " + passportNumberForeign);
                Console.WriteLine("Визы:");

                if (visas.Length > 0)
                {
                    for (int i = 0; i < visas.Length; i++)
                    {
                        Console.WriteLine(visas[i]);
                    }
                }
                else
                {
                    Console.WriteLine("Нет виз.");
                }
            }
        }

        class Program2
        {
            static void Main(string[] args)
            {
                Builder builder = new Builder("Иван", 30, "мужской", 10);
                builder.Greet();
                builder.Build();

                Sailor sailor = new Sailor("Петр", 25, "мужской", "Адмирал Кузнецов");
                sailor.Greet();
                sailor.Sail();

                Pilot pilot = new Pilot("Анна", 35, "женский", "Boeing 737");
                pilot.Greet();
                pilot.Fly();

                Passport passport = new Passport("Иванов Иван Иванович", "1234567890", new DateTime(2020, 1, 1));
                passport.DisplayInfo();

                Console.WriteLine();

                string[] visas = { "Виза США", "Виза Великобритании" };
                ForeignPassport foreignPassport = new ForeignPassport("Петров Петр Петрович", "0987654321", new DateTime(2021, 1, 1), "ABC123XYZ", visas);
                foreignPassport.DisplayInfo();
            }
        }


        //static void Main(string[] args)
        //{
        //}
    }
}
