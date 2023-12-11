namespace DrinksMaskineREST.Models
{
    public class Opskrift
    {
        public int antalIngs { get; set; }

        public Dictionary<string, string> Ingredientser { get; set; }

        public Opskrift(DrinkModel model)
        {
            Ingredientser = new Dictionary<string, string>();
            Ingredientser.Add(model.strIngredient1, model.strMeasure1);
            Ingredientser.Add(model.strIngredient2, model.strMeasure2);

            if (model.strIngredient3 != null)
            {
                Ingredientser.Add(model.strIngredient3, model.strMeasure3);
            }
            if (model.strIngredient4 != null)
            {
                Ingredientser.Add(model.strIngredient4, model.strMeasure5);
            }
            if (model.strIngredient5 != null)
            {
                Ingredientser.Add(model.strIngredient5, model.strMeasure5);
            }
            if (model.strIngredient6 != null)
            {
                Ingredientser.Add(model.strIngredient6, model.strMeasure6);
            }

            antalIngs = Ingredientser.Count();
            
        }
    }
}
