namespace Chapter_15_Secret_Ingredients
{
    public class Amy
    {
        public GetSecretIngredients AmysSecretIngredientsMethod => new GetSecretIngredients(AmysSecretIngredient);
        
        private string AmysSecretIngredient(int amount)
        {
            if (amount < 10)
            {
                return amount + " cans of sardines -- you need more!";
            }

            return amount + " cans of sardines";
        }
    }
}