using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parcial1.Controllers;
using Parcial1.Models;

namespace Parcial1.Tests
{
    [TestClass]
    public class UnitTestRomero            
    {
        [TestMethod]
        public void TestMethodGetRomeroes()
        {
            //arrange
            RomeroesController romerocontroller = new RomeroesController();
            //act
            var romeroes = romerocontroller.GetRomeroes();
            //assert
            Assert.IsNotNull(romeroes);
                                
        }
        [TestMethod]
        public void TestMethodPostRomeroes()
        {
            //arrange
            RomeroesController romerocontroller = new RomeroesController();
            Romero romero = new Romero();
            romero.FriendofRomero = "Carlos";
            romero.Place = 0;
            romero.Email = "Carlo@gmail.com";
            romero.Birthdate = "03/04/1998";
            //act
            var romeroes = romerocontroller.PostRomero(romero);
            //assert
            Assert.IsNotNull(romeroes);

        }


    }
}
