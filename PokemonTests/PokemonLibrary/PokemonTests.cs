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
        public void LevelUpTest()
        {
            Pokemon bulbasaur = new Pokemon("Bulbasaur", 5, "Grass");

            bulbasaur.LevelUp();

            Assert.AreEqual(6, bulbasaur.Level);
        }
    }
}