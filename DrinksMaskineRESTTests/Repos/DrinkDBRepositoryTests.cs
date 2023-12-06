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

namespace DrinksMaskineREST.Repos.Tests
{
    [TestClass()]
    public class DrinkDBRepositoryTests
    {
        private static IDrinkRepository _repository;

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
            Assert.Fail();
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