using System.Runtime.InteropServices;

namespace DrinksMaskineREST.Models
{
    public class DrinkModel
    {
        #region Properties From cocktailAPI
        public string? idDrink { get; set; } //Id til at hente på cocktail API. Se nedenunder for vores eget id
        public string strDrink { get; set; }
        public string? strTags { get; set; }
        public string? strVideo { get; set; }
        public string? strCategory { get; set; }
        public string? strIBA { get; set; }
        public string? strAlcoholic { get; set; }
        public string? strGlass { get; set; }
        public string? strInstructions { get; set; }
        public string? strDrinkThumb { get; set; }
        public string strIngredient1 { get; set; }
        public string strIngredient2 { get; set; }
        public string? strIngredient3 { get; set; }
        public string? strIngredient4 { get; set; }
        public string? strIngredient5 { get; set; }
        public string? strIngredient6 { get; set; }
        public string strMeasure1 { get; set; }
        public string? strMeasure2 { get; set; }
        public string? strMeasure3 { get; set; }
        public string? strMeasure4 { get; set; }
        public string? strMeasure5 { get; set; }
        public string? strMeasure6 { get; set; }
        public string? strImageSource { get; set; }
        #endregion

        #region Custom Properties
        public int Id { get; set; } // Vores eget id
        public string? Creator { get; set; }
        #endregion

        public DrinkModel()
        {
            
        }

        public void Validate()
        {
            ValidateId();
            ValidateName();
            ValidateCategory();
            ValidateAlcoholic();
            ValidateIngredients();
            ValidateCreator();
        }

        public void ValidateId()
        {
            if (idDrink == null)
                throw new Exception("idDrink is null");

            if (int.TryParse(idDrink, out int id))
            {
                if (id <= 0)
                    throw new Exception("idDrink is less than or equal to 0");
            }
            else
                throw new Exception("idDrink is not a number");
        }

        public void ValidateName()
        {
            if (strDrink == null)
                throw new Exception("strDrink is null");

            if (strDrink.Length < 1)
                throw new Exception("strDrink is less than 1 character");

            if (strDrink.Length > 64)
                throw new Exception("strDrink is more than 64 characters");

            if (strDrink.Trim().Length < 1)
                throw new Exception("strDrink is less than 1 character");

            if (strDrink.Trim().Length > 64)
                throw new Exception("strDrink is more than 64 characters");
        }

        public void ValidateCategory()
        {
            if (strCategory == null)
                throw new Exception("strCategory is null");

            if (strCategory.Length <= 1)
                throw new Exception("strCategory is less than 1 character");

            if (strCategory.Length > 64)
                throw new Exception("strCategory is more than 64 characters");

            if (strCategory.Trim().Length < 1)
                throw new Exception("strCategory is less than 1 character");

            if (strCategory.Trim().Length > 64)
                throw new Exception("strCategory is more than 64 characters");

            if (int.TryParse(strCategory, out int id))
                throw new Exception("strCategory is a number");
        }

        public void ValidateAlcoholic()
        {
            if (strAlcoholic == null)
                throw new Exception("strAlcoholic is null");

            if (strAlcoholic.ToLower() != "alcoholic" && strAlcoholic.ToLower() != "non alcoholic")
                throw new Exception("strAlcoholic is not 'alcoholic' or 'non alcoholic'");
        }

        public void ValidateIngredients()
        {
            if (strIngredient1 == null || strIngredient2 == null)
                throw new Exception("strIngredient is null");

            if (strIngredient1.Length <= 1 || strIngredient2.Length <= 1)
                throw new Exception("strIngredient is less than 1 character");

            if (strIngredient1.Length > 64 || strIngredient2.Length > 64)
                throw new Exception("strIngredient is more than 64 characters");

            if (strIngredient1.Trim().Length < 1 || strIngredient2.Trim().Length < 1)
                throw new Exception("strIngredient is less than 1 character");

            if (strIngredient1.Trim().Length > 64 || strIngredient2.Trim().Length > 64)
                throw new Exception("strIngredient is more than 64 characters");
        }

        public void ValidateCreator()
        {
            if (strDrink.Trim().Length > 64)
                throw new Exception("strDrink is more than 64 characters");
        }

    }
}
