using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    class Person
    {
        private string name;
        private bool sex;
        private int age;
        public string Name
        {
            get => name;
            set => name = value;
        }
        public char Sex
        {
            get => sex ? 'F' : 'M';
            set { switch (value) { case 'M': sex = false; break; case 'F': sex = true; break; } }
        }
        public int Age
        {
            get => age;
            set => age = value;
        }
        public Person(string name, char sex, int age)
        {
            Alerter.Green("New person created.");
            this.name = name;
            switch (sex) { case 'M': this.sex = false; break; case 'F': this.sex = true; break; }
            this.age = age;
        }
        public Person()
        {
            Alerter.Green("New person created");
            this.name = "Undefined";
            this.sex = false;
            this.age = 0;
        }
        public void Print() 
        {
            Alerter.Green("Printing info."); 
            Console.WriteLine($"Class: Person; Name: {this.Name}; Sex: {this.Sex}; Age: {this.Age}.");
        }
        public void Input()
        {
            Alerter.Green("Editing data.");

#pragma warning disable CS8601 // Возможно, назначение-ссылка, допускающее значение NULL.
            Console.Write("Name: "); this.Name = Console.ReadLine();
#pragma warning restore CS8601 // Возможно, назначение-ссылка, допускающее значение NULL.

            Console.Write("Sex (M/F): "); this.Sex = Char.ToUpper(Console.ReadKey().KeyChar);

            Console.Write("\nAge: "); this.Age = Convert.ToInt32(Console.ReadLine());
        }
        ~Person() => Alerter.Red("Person \"" + this.Name + "\" terminated.");
    }
}
