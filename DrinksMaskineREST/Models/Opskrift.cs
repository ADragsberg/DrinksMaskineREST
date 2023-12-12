namespace DrinksMaskineREST.Models
{
    public class Opskrift
    {
        public int AntalIngs { get; set; }

        public Dictionary<string, string> Ingredienser { get; set; }

        public Opskrift(DrinkModel model)
        {
            Ingredienser = new Dictionary<string, string>();
            Ingredienser.Add(model.strIngredient1, model.strMeasure1);
            Ingredienser.Add(model.strIngredient2, model.strMeasure2);

            if (!String.IsNullOrEmpty(model.strIngredient3))
            {
                Ingredienser.Add(model.strIngredient3, model.strMeasure3);
            }
            if (!String.IsNullOrEmpty(model.strIngredient4))
            {
                Ingredienser.Add(model.strIngredient4, model.strMeasure4);
            }
            if (!String.IsNullOrEmpty(model.strIngredient3))
            {
                Ingredienser.Add(model.strIngredient5, model.strMeasure5);
            }
            if (!String.IsNullOrEmpty(model.strIngredient3))
            {
                Ingredienser.Add(model.strIngredient6, model.strMeasure6);
            }

            AntalIngs = Ingredienser.Count();
            
        }
    }
}
