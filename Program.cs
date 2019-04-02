using System;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human vlad = new Human("Vlad");
            Human dima = new Human("Dima", 20, 30, 40, 3000);
            vlad.Attack(dima);
            vlad.Attack(dima);

        }
    }

    public class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        public int Health
        {
            get { return _health; }
            set { _health = value; }
        }
        private int _health;


        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            _health = 100;
        }

        public Human(string name, int strength, int intelligence, int dexterity, int health)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            _health = health;
        }

        public int Attack(Human target)
        {
            target.Health -= Strength * 5;
            Console.WriteLine(target.Name + " Health: " + target.Health);
            return target.Health;
        }
    }
}
