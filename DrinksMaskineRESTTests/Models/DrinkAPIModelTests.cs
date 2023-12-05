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
    public class DrinkModelTests
    {

        [TestMethod()]
        public void IdTest()
        {
            DrinkModel drink = new DrinkModel();
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
            DrinkModel drink = new DrinkModel();
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
        public void DrinkNameCreatorTest()
        {
            DrinkModel drink = new DrinkModel();

            drink.strDrink = "qqqqq wwwww eeeee rrrrr ttttt yyyyy uuuuu iiiii ppppp aaaaa sssss"; // 65 chars
            Assert.ThrowsException<Exception>(() => drink.ValidateCreator());
        }


        [TestMethod()]
        public void CategoryTest()
        {
            DrinkModel drink = new DrinkModel();
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
            DrinkModel drink = new DrinkModel();
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
            DrinkModel drink = new DrinkModel();
            drink.strIngredient1 = "1";
            drink.strIngredient2 = "2";
            Assert.ThrowsException<Exception>(() => drink.ValidateIngredients());

            drink.strIngredient1 = "a";
            drink.strIngredient2 = "b";
            Assert.ThrowsException<Exception>(() => drink.ValidateIngredients());

            drink.strIngredient1 = "";
            drink.strIngredient2 = "";
            Assert.ThrowsException<Exception>(() => drink.ValidateIngredients());

            drink.strIngredient1 = null;
            drink.strIngredient2 = null;
            Assert.ThrowsException<Exception>(() => drink.ValidateIngredients());

            drink.strIngredient1 = " ";
            drink.strIngredient2 = " ";
            Assert.ThrowsException<Exception>(() => drink.ValidateIngredients());

            drink.strIngredient1 = "qqqqq wwwww eeeee rrrrr ttttt yyyyy uuuuu iiiii ppppp aaaaa sssss"; // 65 chars
            drink.strIngredient2 = "qqqqq wwwww eeeee rrrrr ttttt yyyyy uuuuu iiiii ppppp aaaaa sssss";
            Assert.ThrowsException<Exception>(() => drink.ValidateIngredients());

            drink.strIngredient1 = "Vodka";
            drink.strIngredient2 = "Whisky";
            drink.ValidateIngredients();
        }
   
    }
}