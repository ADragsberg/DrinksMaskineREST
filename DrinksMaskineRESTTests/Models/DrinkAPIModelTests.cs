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

            drink.strDrink = "Black Russian";
            drink.ValidateName();
        }

        [TestMethod()]
        public void CategoryTest()
        {
            DrinkAPIModel drink = new DrinkAPIModel();
            drink.strCategory = "1";
            Assert.ThrowsException<Exception>(() => drink.ValidateCategory());

            drink.strCategory = "a";
            Assert.ThrowsException<Exception>(() => drink.ValidateCategory());

            drink.strCategory = "";
            Assert.ThrowsException<Exception>(() => drink.ValidateCategory());

            drink.strCategory = null;
            Assert.ThrowsException<Exception>(() => drink.ValidateCategory());

            drink.strCategory = " ";
            Assert.ThrowsException<Exception>(() => drink.ValidateCategory());

            drink.strCategory = "qqqqq wwwww eeeee rrrrr ttttt yyyyy uuuuu iiiii ppppp aaaaa sssss"; // 65 chars
            Assert.ThrowsException<Exception>(() => drink.ValidateCategory());

            drink.strCategory = "Ordinary Drink";
            drink.ValidateCategory();
        }

        [TestMethod()]
        public void AlcoholicTest()
        {
            DrinkAPIModel drink = new DrinkAPIModel();
            drink.strAlcoholic = "1";
            Assert.ThrowsException<Exception>(() => drink.ValidateAlcoholic());

            drink.strAlcoholic = "a";
            Assert.ThrowsException<Exception>(() => drink.ValidateAlcoholic());

            drink.strAlcoholic = "";
            Assert.ThrowsException<Exception>(() => drink.ValidateAlcoholic());

            drink.strAlcoholic = null;
            Assert.ThrowsException<Exception>(() => drink.ValidateAlcoholic());

            drink.strAlcoholic = " ";
            Assert.ThrowsException<Exception>(() => drink.ValidateAlcoholic());

            drink.strAlcoholic = "qqqqq wwwww eeeee rrrrr ttttt yyyyy uuuuu iiiii ppppp aaaaa sssss"; // 65 chars
            Assert.ThrowsException<Exception>(() => drink.ValidateAlcoholic());

            drink.strAlcoholic = "Alcoholic";
            drink.ValidateAlcoholic();

            drink.strAlcoholic = "Non alcoholic";
            drink.ValidateAlcoholic();
        }

        [TestMethod()]
        public void Ingredient1Test()
        {
            DrinkAPIModel drink = new DrinkAPIModel();
            drink.strIngredient1 = "1";
            Assert.ThrowsException<Exception>(() => drink.ValidateIngredient1());

            drink.strIngredient1 = "a";
            Assert.ThrowsException<Exception>(() => drink.ValidateIngredient1());

            drink.strIngredient1 = "";
            Assert.ThrowsException<Exception>(() => drink.ValidateIngredient1());

            drink.strIngredient1 = null;
            Assert.ThrowsException<Exception>(() => drink.ValidateIngredient1());

            drink.strIngredient1 = " ";
            Assert.ThrowsException<Exception>(() => drink.ValidateIngredient1());

            drink.strIngredient1 = "qqqqq wwwww eeeee rrrrr ttttt yyyyy uuuuu iiiii ppppp aaaaa sssss"; // 65 chars
            Assert.ThrowsException<Exception>(() => drink.ValidateIngredient1());

            drink.strIngredient1 = "Vodka";
            drink.ValidateIngredient1();
        }
   
    }
}