namespace Pokemon.PokemonLibrary
{
    public class Pokemon
    {
        //private fields
        private string _name = "";
        private int _level;
        private int _healthPoint;
        private int _experiencePoint;
        private string _type = "";
        private int _attack;
        private int _defense;

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
        public Pokemon(string name, int level = 1, string type = "Fire")
        {
            _name = name;
            _level = level;
            _type = type;
            _healthPoint = 100;
            _experiencePoint = 0;
            _attack = 10;
            _defense = 8;
        }
        //methods
        public void GainExperience(int amount)
        {
            _experiencePoint += amount;
            if (_experiencePoint >= 100)
            {
                LevelUp();
            }
        }
        public void LevelUp()
        {
            _level++;
            _experiencePoint = 0;
            _attack += 3;
            _defense += 1;
            _healthPoint += 10;
        }
    }
}
