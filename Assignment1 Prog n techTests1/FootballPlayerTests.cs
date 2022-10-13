using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment1_Prog_n_tech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Prog_n_tech.Tests
{
    [TestClass()]
    public class FootballPlayerTests
    {

       
        [TestMethod()]
        public void ToStringTest()
        {
            FootballPlayer player = new FootballPlayer() { Name = "Vincent", ShirtNumber = 39, Age = 26, Id = 3926 };
            string str = player.ToString();
            Assert.AreEqual(str, player.ToString());

        }
        [TestMethod()]
        public void NameValidatorTest()
        {
          
            FootballPlayer player = new FootballPlayer() { Name = "", ShirtNumber = 39, Age = 26, Id = 3926 };
            Assert.ThrowsException<ArgumentException>(() => player.NameValidator());

            FootballPlayer player1 = new FootballPlayer() { Name = null, ShirtNumber = 39, Age = 26, Id = 3926 };
            Assert.ThrowsException<ArgumentNullException>(() => player1.NameValidator());

        }


        [TestMethod()]
        public void AgeValidatorTest()
        {

            FootballPlayer player = new FootballPlayer() { Name = "Vincent", ShirtNumber = 39, Age = 1, Id = 3926 };
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => player.AgeValidator());

           
        }

        [TestMethod()]
        public void ShirtNumberValidatorTest()
        {
            FootballPlayer player = new FootballPlayer() { Name = "Vincent", ShirtNumber = 0, Age = 0, Id = 3926 };
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => player.ShirtNumberValidator());

            FootballPlayer player1 = new FootballPlayer() { Name = "Vincent", ShirtNumber = 100, Age = 0, Id = 3926 };
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => player.ShirtNumberValidator());

            FootballPlayer player2 = new FootballPlayer() { Name = "Vincent", ShirtNumber = -1, Age = 0, Id = 3926 };
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => player.ShirtNumberValidator());


        }

       
    }
    }
