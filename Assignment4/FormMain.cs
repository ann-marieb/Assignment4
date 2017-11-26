//FormMain.cs
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
    public partial class FormMain : Form
    {
        private const int maxNumOfIngredients = 20; //max number of ingredients possible in a recipe
        private const int maxNumOfRecipes = 50; //max number of recipes possible
        private int selectedListIndex;

        Recipe recipeObj1 = new Recipe(maxNumOfIngredients); //create temporary recipe object
        RecipeManager recipeManagerObj = new RecipeManager(maxNumOfRecipes); // create recipe manager object
        
        //constructor
        public FormMain() 
        {
            InitializeComponent();
            InitializeGui();
        }

        /// <summary>
        /// initialize user interface 
        /// </summary>
        private void InitializeGui()
        {
            this.Text = "Apu's Cook Book";
            cboCategory.DataSource = Enum.GetValues(typeof(FoodCategory));
            recipeObj1.DefaultValues();
            UpdateGuiRecipe();
            lblNumOfRecipes.Text = "0";
        }

        /// <summary>
        /// Save name when changed to recipeObj1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param> 
        private void txtNameOfRecipe_TextChanged(object sender, EventArgs e)
        {
            recipeObj1.Name = txtNameOfRecipe.Text.Trim();
        }

        /// <summary>
        /// Save description when changed to recipeObj1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param> 
        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            recipeObj1.Description = txtDescription.Text.Trim();
        }

        /// <summary>
        /// Save category when changed to recipeObj1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param> 
        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            recipeObj1.Category = (FoodCategory)cboCategory.SelectedIndex;
        }

        /// <summary>
        /// edit ingredients to recipeObj1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditIngredients_Click(object sender, EventArgs e)
        {
            FormIngredients formIngredientsObj = new FormIngredients(new Recipe (recipeObj1)); // create object
            DialogResult dialogResult = formIngredientsObj.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                recipeObj1 = formIngredientsObj.Recipe;
                UpdateGuiList();
            }
        }

        /// <summary>
        /// add values of recipeObj1 to recipeManagerObj on "Add recipe" click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            recipeObj1.Category = (FoodCategory)cboCategory.SelectedIndex;
            recipeObj1.Name = txtNameOfRecipe.Text.Trim();
            recipeObj1.Description = txtDescription.Text.Trim();

            if (string.IsNullOrEmpty(recipeObj1.Name)) // if no name is given
            {
                MessageBox.Show("No name!");
            }
            else
            {
                recipeManagerObj.Add(recipeObj1);
                UpdateGuiList();
                recipeObj1.DefaultValues(); // set all values to default
                UpdateGuiRecipe();
            }
            return;
        }

        /// <summary>
        /// Update user interface with list and total number of recipes
        /// </summary>
        private void UpdateGuiList()
        {
            string[] recipeListStrings = recipeManagerObj.RecipeArrayToString();
            lstRecipeList.Items.Clear();
            lstRecipeList.Items.AddRange(recipeListStrings);

            lblNumOfRecipes.Text = recipeManagerObj.GetCurrentNumOfRecipes().ToString();
            //lblNumOfRecipes.Text = lstRecipeList.Items.Count.ToString(); gör samma sak
         }

        /// <summary>
        /// Update user interface with recipe
        /// </summary>
        private void UpdateGuiRecipe()
        {
            txtNameOfRecipe.Text = recipeObj1.Name;
            cboCategory.SelectedItem = recipeObj1.Category;
            txtDescription.Text = recipeObj1.Description;
        }

        /// <summary>
        /// When recipe is selected in list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstRecipeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedListIndex = lstRecipeList.SelectedIndex;
            int index = findSelectedRecipeIndex(selectedListIndex);

            recipeObj1 = recipeManagerObj.GetRecipeAt(index);

            UpdateGuiRecipe();
        }

        /// <summary>
        /// find the recipe index in recipeArray corresponding to SelectedIndex
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private int findSelectedRecipeIndex(int index)
        {
            int j = 0;
            int i;
            for (i = 0; i < maxNumOfRecipes; i++)
            {
                if (recipeManagerObj.GetRecipeAt(i) != null)
                {
                    if (j == index)
                        break;
                    j++;
                }
            }
            return i;
        }

        /// <summary>
        /// update recipe at specified index
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateRecipe_Click(object sender, EventArgs e)
        {
            int index = findSelectedRecipeIndex(selectedListIndex);
            recipeManagerObj.ChangeRecipe(index, recipeObj1);
            UpdateGuiList();
            recipeObj1.DefaultValues(); // set all values to default
            UpdateGuiRecipe();
        }

        /// <summary>
        /// delete recipe at specified index
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteRecipe_Click(object sender, EventArgs e)
        {
            int index = findSelectedRecipeIndex(lstRecipeList.SelectedIndex);
            recipeManagerObj.DeleteRecipe(index);
            UpdateGuiList();
            recipeObj1.DefaultValues(); // set all values to default
            UpdateGuiRecipe();
        }
    } //close class
} //close namespace
