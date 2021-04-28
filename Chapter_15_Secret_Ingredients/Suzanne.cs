namespace Chapter_15_Secret_Ingredients
{
    public class Suzanne
    {
        public GetSecretIngredients MySecretIngredientMethod => new GetSecretIngredients(SuzannesSecretIngredient);
        
        private string SuzannesSecretIngredient(int amount) => amount + " ounces of cloves";
    }
}