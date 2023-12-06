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
            strCategory = "V",
            strAlcoholic = "alcoholic",
            strIngredient1 = "V",
            strIngredient2 = "V",
            strMeasure1 = "1 oz",
            strMeasure2 = "1 oz",
            Id = 1
        };
                
        private DrinkModel _validMaxDrink = new DrinkModel() { 
            idDrink = null , 
            strDrink = "qqqqq wwwww eeeee rrrrr ttttt yyyyy uuuuu iiiii ppppp aaaaa ssss", //64 characters with spaces
            strCategory = "qqqqq wwwww eeeee rrrrr ttttt yyyyy uuuuu iiiii ppppp aaaaa ssss",
            strAlcoholic = "NON ALCOHOLIC",
            strIngredient1 = "qqqqq wwwww eeeee rrrrr ttttt yyyyy uuuuu iiiii ppppp aaaaa ssss",
            strIngredient2 = "qqqqq wwwww eeeee rrrrr ttttt yyyyy uuuuu iiiii ppppp aaaaa ssss",
            strMeasure1 = "1 L",
            strMeasure2 = "1 L",
            Id = 1
        };

        private DrinkModel _invalid = new DrinkModel(){strDrink = ""};

        [ClassInitialize]
        public static void RepoSetup()
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