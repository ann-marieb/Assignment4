//FormIngredients.cs
//Ann-Marie Bergström 2017-11-12

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class FormIngredients : Form
    {
        Recipe recipeObj2; //declare recipeObj2 as type Recipe

        public Recipe Recipe => recipeObj2; 

        //constructor
        public FormIngredients(Recipe recipe)
        {
            InitializeComponent();

            recipeObj2 = recipe; // set recipeObj2 to recipe

            InitializeGui();
            UpdateGui();
        }

        /// <summary>
        /// Initialize user interface
        /// </summary>
        private void InitializeGui()
        {
            if (string.IsNullOrEmpty(recipeObj2.Name)) // check if name is given
                this.Text = "No recipe name";
            else
                this.Text = recipeObj2.Name + ": Add ingredients";

            if (recipeObj2.Ingredients == null) 
                recipeObj2.Ingredients = new string[recipeObj2.MaxNumberOfIngredients];

            lstIngredients.Items.Clear();
            toolTipIngredient.SetToolTip(txtIngredient, "Example: 2 dl of milk");
        }

        /// <summary>
        /// update user interface with list and total number of ingredients
        /// </summary>
        private void UpdateGui()
        {
            lstIngredients.Items.Clear(); //clear ingredients list before writing new list

            lblNumOfIngredients.Text = recipeObj2.GetCurrentNumOfIngredients().ToString(); // write no of ingredients
            lstIngredients.Items.AddRange(recipeObj2.Ingredients); //write ingredients list

            txtIngredient.Clear(); // Clear ingredient textbox to enable new input
            txtIngredient.Focus(); //cursor back to ingredient textbox
        }



            /// <summary>
            /// add ingredient to recipeObj2 on "Add ingredient" click
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btnAddIngr_Click(object sender, EventArgs e) 
        {
            if (string.IsNullOrEmpty(txtIngredient.Text))
            {
                MessageBox.Show("No ingredient!");
                return;
            }
            recipeObj2.AddIngredient(txtIngredient.Text);
            UpdateGui();
        }

        /// <summary>
        /// end editing of ingredients
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEndAddIngr_Click(object sender, EventArgs e)  
        {
              
        }

        /// <summary>
        /// cancel editing of ingredients
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelAddIngr_Click(object sender, EventArgs e)
        {
            for(int i=0; i < recipeObj2.MaxNumberOfIngredients; i++) 
            recipeObj2.DeleteIngredientAt(i);
        }

        /// <summary>
        /// update ingredient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditIngr_Click(object sender, EventArgs e)
        {
            int index = findSelectedIngredient(lstIngredients.SelectedIndex);
            recipeObj2.ChangeIngredientAt(index, txtIngredient.Text.Trim());
            UpdateGui();
        }

        /// <summary>
        /// delete ingredient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteIngr_Click(object sender, EventArgs e)
        {
            int index = findSelectedIngredient(lstIngredients.SelectedIndex);
            recipeObj2.DeleteIngredientAt(index);
            UpdateGui();
        }

        /// <summary>
        /// select from list, get ingredient and display
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = findSelectedIngredient(lstIngredients.SelectedIndex);
            txtIngredient.Text = recipeObj2.GetIngredientAt(i); 
        }

        /// <summary>
        /// find the ingredient in the position in ingredientArray corresponding to SelectedIndex
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        // 
        private int findSelectedIngredient(int index) 
        {
            int j = 0;
            int i;

            for (i = 0; i < recipeObj2.MaxNumberOfIngredients; i++)
            {
                if (recipeObj2.GetIngredientAt(i) != null)
                {
                    if (j == index)
                        break;
                    j++;
                }
            }
            return i;
        }

        /// <summary>
        /// Enter key instead of click Add ingredient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtIngredient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btnAddIngr_Click(sender, e);
                e.Handled = true;
            }
        }
    } //close class
} //close namespace
