//Recipe.cs
//Ann-Marie Bergström 2017-11-12

using System;
using System.Windows.Forms;

namespace Assignment4
{
    public class Recipe
    {
        private string[] ingredientArray; // declare array of ingredients
        
        public string[] Ingredients
        {
            get { return ingredientArray; }
            set { ingredientArray = value; }
        }
        public FoodCategory Category { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public int MaxNumberOfIngredients
        {
            get { return ingredientArray.Length; }
        }

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="maxNumberOfIngredients"></param>
        public Recipe(int maxNumberOfIngredients) 
        {
            ingredientArray = new string[maxNumberOfIngredients]; //create ingredientArray with length maxNumberOfIngredients
            DefaultValues(); //set values to default
        }

        public Recipe (Recipe other)
        {
            this.Name = other.Name;
            this.Category = other.Category;
            this.Description = other.Description;
            this.ingredientArray = new string[other.Ingredients.Length];
            for (int i = 0; i < other.Ingredients.Length; i++)
            {
                this.Ingredients[i] = other.Ingredients[i];
            }
        }

        /// <summary>
        /// add the ingredient to ingredientArray
        /// </summary>
        public bool AddIngredient(string value)
        {
            int index = FindVacantPosition(); //to find vacant position, -1 if none
            if (index >= 0)
            {
                ingredientArray[index] = value;
                return true;
            }
            return false;
        }

        /// <summary>
        /// get the ingredient at specified index
        /// </summary>
        /// <param name="index"></param>
        /// <returns>ingredient</returns>
        public string GetIngredientAt(int index)
        {
            string value;

            if (CheckIndex(index))
                value = ingredientArray[index];
            else
                value = "No ingredient";
            return value;
        }

        /// <summary>
        /// change ingredient text at specified index
        /// </summary>
        /// <param name="index"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool ChangeIngredientAt(int index, string value)
        {
            if (CheckIndex(index))
            {
                ingredientArray[index] = value;
                return true;
            }
            return false;
        }

        /// <summary>
        /// delete ingredient at specified index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool DeleteIngredientAt(int index)
        {
            if (CheckIndex(index))
            {
                ingredientArray[index] = string.Empty;
                return true;
            }
            return false;
        }

        /// <summary>
        /// set recipeArray values to default
        /// </summary>
        public void DefaultValues()
        {
            for (int i = 0; i < ingredientArray.Length; i++)
                ingredientArray[i] = string.Empty;
            Name = string.Empty; 
            Category = FoodCategory.Vegetarian; // set category
            Description = string.Empty;
        }

        /// <summary>
        /// find a vacant position in ingredientArray
        /// </summary>
        /// <returns> index of vacant position, -1 if none</returns>
        private int FindVacantPosition()
        {
            for (int i = 0; i < ingredientArray.Length; i++)
            {
                if (string.IsNullOrEmpty(ingredientArray[i]))
                    return i;
            }
            return -1; // if no vacant position found return -1
        }

        /// <summary>
        /// check if index is within ingredientArray's range
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private bool CheckIndex(int index)
        {
            return (index >= 0 && index < ingredientArray.Length);
        }

        /// <summary>
        /// count positions with values
        /// </summary>
        /// <returns> current number of ingredients</returns>
        public int GetCurrentNumOfIngredients()
        {
            int count = 0;
            for (int i = 0; i < ingredientArray.Length; i++)
            {
                if (!string.IsNullOrEmpty(ingredientArray[i]))
                    count++;
            }
            return count;
        }

        /// <summary>
        /// create recipe string to display in list
        /// </summary>
        /// <returns>formatted recipe text</returns>
        public override string ToString()
        {
            int chars = Math.Min(Description.Length, 15);
            string descriptionText = Description.Substring(0, chars);

            if (string.IsNullOrEmpty(descriptionText))
                descriptionText = "No description!";

            string textOut = string.Format("{0, -20} {1,4}      {2, -12}   {3, -15}",
                            Name, GetCurrentNumOfIngredients(), Category.ToString(),  descriptionText);
            return textOut;
        }

    } // close class
} //close namespace