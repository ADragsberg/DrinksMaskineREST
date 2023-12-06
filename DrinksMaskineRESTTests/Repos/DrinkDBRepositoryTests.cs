using Microsoft.VisualStudio.TestTools.UnitTesting;
using DrinksMaskineREST.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Secret;
using Microsoft.EntityFrameworkCore;
using DrinksMaskineREST.Models;

namespace DrinksMaskineREST.Repos.Tests
{
    [TestClass()]
    public class DrinkDBRepositoryTests
    {
        private static IDrinkRepository _repository;
        private DrinkModel _validMinDrink = new DrinkModel() {
            idDrink = null,
            strDrink = "V",
            strCategory = "V1",
            strAlcoholic = "alcoholic",
            strIngredient1 = "V1",
            strIngredient2 = "B1",
            strMeasure1 = "1 oz",
            strMeasure2 = "1 oz",
            Id = 0,
            Creator = "V"
        };
                
        private DrinkModel _validMaxDrink = new DrinkModel() { 
            idDrink = null , 
            strDrink = "qqqqq wwwww eeeee rrrrr ttttt yyyyy uuuuu iiiii ppppp aaaaa ssss", //64 characters with spaces
            strCategory = "qqqqq wwwww eeeee rrrrr ttttt yyyyy uuuuu iiiii ppppp aaaaa ssss",
            strAlcoholic = "NON ALCOHOLIC",
            strIngredient1 = "qqqqq wwwww eeeee rrrrr ttttt yyyyy uuuuu iiiii ppppp aaaaa ssss",
            strIngredient2 = "qqqqq wwwww eeeee rrrrr ttttt yyyyy uuuuu iiiii ppppp aaaaa dddd",
            strMeasure1 = "100 L",
            strMeasure2 = "100 L",
            Id = 0,
            Creator = "qqqqq wwwww eeeee rrrrr ttttt yyyyy uuuuu iiiii ppppp aaaaa ssss"
        };

        private DrinkModel _invalid = new DrinkModel(){strDrink = ""};

        private DrinkModel _invalidForFaaIngr = new DrinkModel()
        {
            idDrink = null,
            strDrink = "V",
            strCategory = "V",
            strAlcoholic = "alcoholic",
            strIngredient1 = "V",
            strMeasure1 = "1 oz",
            Id = 1,
            Creator = "V"
        };

        [ClassInitialize]
        public static void InitOnce(TestContext testContext)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DrinksDBContext>();
            optionsBuilder.UseSqlServer(Secrets.ConnectionString);
            DrinksDBContext _dbContext = new DrinksDBContext(optionsBuilder.Options);
            _dbContext.Database.ExecuteSqlRaw("TRUNCATE TABLE dbo.DrinkModels");
            _repository = new DrinkDBRepository(_dbContext);

        }

        [TestMethod()]
        public void DrinkDBRepositoryTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AddTest()
        {
            DrinkModel drink1 = _repository.Add(_validMinDrink);
            DrinkModel drink2 = _repository.Add(_validMaxDrink);

            //DrinkNavn
            Assert.IsTrue(_repository.GetById(drink1.Id).strDrink == _validMinDrink.strDrink);
            Assert.IsTrue(_repository.GetById(drink2.Id).strDrink == _validMaxDrink.strDrink);

            //CreatorNavn
            Assert.IsTrue(_repository.GetById(drink1.Id).Creator == _validMinDrink.Creator);
            Assert.IsTrue(_repository.GetById(drink2.Id).Creator == _validMaxDrink.Creator);

            //Ingredienser
            Assert.IsTrue(_repository.GetById(drink1.Id).strIngredient1 == _validMinDrink.strIngredient1);
            Assert.IsTrue(_repository.GetById(drink1.Id).strIngredient2 == _validMinDrink.strIngredient2);

            Assert.IsTrue(_repository.GetById(drink2.Id).strIngredient1 == _validMaxDrink.strIngredient1);
            Assert.IsTrue(_repository.GetById(drink2.Id).strIngredient2 == _validMaxDrink.strIngredient2);

            Assert.ThrowsException<Exception>(() => _repository.Add(_invalidForFaaIngr));

            Assert.ThrowsException<Exception>(() => _repository.Add(_invalid));
            
        }
        
        [TestMethod()]
        public void DeleteTest()
        {

        }
        
        [TestMethod()]
        public void UpdateTest()
        {

        }

    }
}