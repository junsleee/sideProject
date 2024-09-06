using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pokemon.PokemonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.PokemonLibrary.Tests
{
    [TestClass()]
    public class PokemonTests
    {
        [TestMethod()]
        public void PokemonTest()
        {
            //arrange
            Pokemon bulbasaur = new Pokemon("Bulbasaur", 5, "Grass");
            //act
            string name = "Bulbasaur";
            int lvl = 5;
            string typing = "Grass";
            //assert
            Assert.AreEqual("Bulbasaur", name);
            Assert.AreEqual(5, lvl);
            Assert.AreEqual("Grass", typing);
            Assert.IsTrue(bulbasaur.IsShiny || !bulbasaur.IsShiny);
        }

        [TestMethod()]
        public void PokemonTest2()
        {
            //arrange
            Pokemon charmander = new Pokemon("Charmander", 5, "Fire");
            //act
            string name = "Charmander";
            int lvl = 5;
            string typing = "Fire";
            //assert
            Assert.AreEqual("Charmander", name);
            Assert.AreEqual(5, lvl);
            Assert.AreEqual("Fire", typing);
            Assert.IsTrue(charmander.IsShiny || !charmander.IsShiny);
        }

        [TestMethod()]
        public void PokemonTest3()
        {
            //arrange
            Pokemon squirtle = new Pokemon("Squirtle", 5, "Water");
            //act
            string name = "Squirtle";
            int lvl = 5;
            string typing = "Water";
            //assert
            Assert.AreEqual("Squirtle", name);
            Assert.AreEqual(5, lvl);
            Assert.AreEqual("Water", typing);
            Assert.IsTrue(squirtle.IsShiny || !squirtle.IsShiny);
        }

        [TestMethod()]
        public void GainExperienceTest()
        {
            Pokemon bulbasaur = new Pokemon("Bulbasaur", 5, "Grass");

            bulbasaur.GainExperience(100);

            Assert.AreEqual(6, bulbasaur.Level);
            Assert.AreEqual(0, bulbasaur.ExperiencePoint);
        }

        [TestMethod()]
        public void GainExperienceTest2()
        {
            Pokemon bulbasaur = new Pokemon("Bulbasaur", 6, "Grass");

            bulbasaur.GainExperience(164);

            Assert.AreEqual(7, bulbasaur.Level);
            Assert.AreEqual(64, bulbasaur.ExperiencePoint);
        }

        [TestMethod()]
        public void LevelUpTest()
        {
            Pokemon bulbasaur = new Pokemon("Bulbasaur", 5, "Grass");

            bulbasaur.LevelUp();

            Assert.AreEqual(6, bulbasaur.Level);
        }

        [TestMethod()]
        public void AttackTest()
        {
            Pokemon bulbasaur = new Pokemon("Bulbasaur", 5, "Grass");
            Pokemon charmander = new Pokemon("Charmander", 5, "Fire");

            bulbasaur.Attack(charmander);
            
            Assert.AreEqual(28, charmander.HealthPoint);
        }

        [TestMethod()]
        public void ShinyTest()
        {
            Pokemon bulbasaur = new Pokemon("Bulbasaur", 5, "Grass");

            Assert.IsTrue(bulbasaur.IsShiny || !bulbasaur.IsShiny);
        }
    }
}