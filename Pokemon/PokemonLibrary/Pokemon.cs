using System.ComponentModel;
using System.Security.Cryptography;

namespace Pokemon.PokemonLibrary
{
    public class Pokemon
    {
        //private fields of basic stats of a pokemon
        private string _name = "";
        private int _level;
        private int _healthPoint = 30;
        private int _experiencePoint = 0;
        private string _type;
        private int _attack = 10;
        private int _defense = 8;
        private bool _isShiny;

        //properties
        public string Name
        {
            get => _name;
            set
            {
                if (value == "Pikachu")
                {
                    //validation mechanism 
                    throw new ArgumentException("Pikachu doesn't exist yet!");
                }

                _name = value;
            }
        }

        public int HealthPoint
        {
            get => _healthPoint;
        }
        public bool IsShiny
        {
            get => _isShiny;
        }
        public int Level
        {
            get => _level;
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Level cannot be less than 1!");
                }
                _level = value;
            }
        }
        public int ExperiencePoint
        {
            get => _experiencePoint;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("EXP cannot be less than 0!");
                }
                _experiencePoint = value;
            }
        }

        //constructor
        public Pokemon(string name, int level = 1, string type = "Fire", bool isShiny = false)
        {
            _name = name;
            _level = level;
            _type = type;
            _isShiny = DetermineIfShiny();
            if (_isShiny) Console.WriteLine($"{_name} is shiny!");
        }

        //methods
        private bool DetermineIfShiny()
        {
            Random random = new Random();
            return random.Next(1, 8193) == 1;
        }
        public void GainExperience(int amount)
        {
            Console.WriteLine($"{_name} gained {amount} EXP!");

            _experiencePoint += amount;

            if (_experiencePoint >= 100)
            {
                LevelUp();
            }

            Console.WriteLine($"{_name}'s EXP is now {_experiencePoint}.");
        }
        public void LevelUp()
        {
            _level++;
            _experiencePoint -= 100;
            _attack += 3;
            _defense += 1;
            _healthPoint += 10;

            Console.WriteLine($"{_name} leveled up to {_level}!");
        }
        public void Attack(Pokemon target)
        {
            int damage = _attack - target._defense;
            if (damage <= 0) damage = 1;
            target._healthPoint -= damage;

            Console.WriteLine($"{_name} attacked {target._name} and dealt {damage} damage.");
        }
    }
}
