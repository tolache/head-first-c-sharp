using System;
using System.Windows.Forms;

namespace Chapter_15_Secret_Ingredients
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        GetSecretIngredients ingredientMethod = null;
        Suzanne suzanne = new Suzanne();
        Amy amy = new Amy();

        private void useIngredient_Click(object sender, System.EventArgs e)
        {
            if (ingredientMethod != null)
                MessageBox.Show("I'll add " + ingredientMethod((int)amount.Value));
            else
                MessageBox.Show("I don't have a secret ingredient!");
        }

        private void getSuzanne_Click(object sender, System.EventArgs e)
        {
            ingredientMethod = new GetSecretIngredients(suzanne.MySecretIngredientMethod);
        }

        private void getAmy_Click(object sender, System.EventArgs e)
        {
            ingredientMethod = new GetSecretIngredients(amy.AmysSecretIngredientsMethod);
        }
    }
}
