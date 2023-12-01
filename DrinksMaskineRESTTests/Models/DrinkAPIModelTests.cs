using Microsoft.VisualStudio.TestTools.UnitTesting;
using DrinksMaskineREST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksMaskineREST.Models.Tests
{
    [TestClass()]
    public class DrinkAPIModelTests
    {
        [TestMethod()]
        public void DrinkAPIModelTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void IdTest()
        {
            DrinkAPIModel drink = new DrinkAPIModel();
            drink.idDrink = "1";
            drink.ValidateId();

            drink.idDrink = "a";
            Assert.ThrowsException<Exception>(()=> drink.ValidateId());

            drink.idDrink = "-1";
            Assert.ThrowsException<Exception>(() => drink.ValidateId());

            drink.idDrink = "0";
            Assert.ThrowsException<Exception>(() => drink.ValidateId());
        }

        [TestMethod()]
        public void NameTest()
        {
            DrinkAPIModel drink = new DrinkAPIModel();
            drink.strDrink = "1";
            drink.ValidateName();

            drink.strDrink = "a";
            drink.ValidateName();

            drink.strDrink = "";
            Assert.ThrowsException<Exception>(() => drink.ValidateName());

            drink.strDrink = null;
            Assert.ThrowsException<Exception>(() => drink.ValidateName());

            drink.strDrink = " ";
            Assert.ThrowsException<Exception>(() => drink.ValidateName());

            drink.strDrink = "qqqqq wwwww eeeee rrrrr ttttt yyyyy uuuuu iiiii ppppp aaaaa sssss"; // 65 chars
            Assert.ThrowsException<Exception>(() => drink.ValidateName());
        }
    }
}