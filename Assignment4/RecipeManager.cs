//RecipeManager.cs
//Ann-Marie Bergström 2017-11-12

using System;

namespace Assignment4
{
    public class RecipeManager
    {
        /// <summary>
        /// declare array of type Recipe to hold recipes
        /// </summary>
        private Recipe[] recipeArray;

        /// constructor
        public RecipeManager(int maxNumOfElements)
        {
            recipeArray = new Recipe[maxNumOfElements]; //create array of recipes with length maxNumOfElements
        }

        /// <summary>
        /// find a vacant position in recipeArray
        /// </summary>
        /// <returns> index of vacant position, -1 if none</returns>

        private int FindVacantPosition()
        {
            for (int i = 0; i < recipeArray.Length; i++)
            {
                if (recipeArray[i] == null)
                    return i;
            }
            return -1; // if no vacant position found return -1
        }

        /// <summary>
        /// check if index is within recipeArray's range
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private bool CheckIndex(int index)
        {
            return (index >= 0 && index < recipeArray.Length);
        }

        /// <summary>
        /// add the recipe values to recipeArray
        /// </summary>
        /// <param name="name"></param>
        /// <param name="category"></param>
        /// <param name="ingredientArray"></param>
        /// <param name="description"></param>
        /// <returns></returns>
        // 
        //public bool Add(string name, FoodCategory category, string[] ingredientArray, string description)
        //{
        //    int index = FindVacantPosition();
        //    if (index >= 0) // if index is -1 there is no vacant position
        //    {
        //        Recipe recipeObjLocal = new Recipe(ingredientArray.Length);
        //        recipeObjLocal.Name = name;
        //        recipeObjLocal.Category = category;
        //        recipeObjLocal.Description = description;

        //        for (int i = 0; i < ingredientArray.Length; i++)
        //        {
        //            recipeObjLocal.Ingredients[i] = ingredientArray[i];
        //        }

        //        recipeArray[index] = recipeObjLocal; // add recipe to array
        //        return true;
        //    }
        //    return false;
        //}
               
        /// <summary> Add new recipe
        /// </summary>
        public bool Add (Recipe recipe)
        {
            int index = FindVacantPosition();
            return ChangeRecipe(index, recipe);
        }

        /// <summary>
        /// count number of recipes in recipeArray
        /// </summary>
        /// <returns>current number of recipes</returns>
        public int GetCurrentNumOfRecipes()
        {
            int count = 0;
            for (int i = 0; i < recipeArray.Length; i++)
            {
                if (recipeArray[i] != null)
                    count++;
            }
            return count;
        }

        /// <summary>
        /// Create list of recipe strings to display
        /// </summary>
        /// <returns>recipe list in string format</returns>
        public string[] RecipeArrayToString() 
        {
            string[] result = new string[GetCurrentNumOfRecipes()]; //create result array object
            int j = 0;

            // for loop to find all recipes in recipeArray
            for (int i=0; i < recipeArray.Length; i++)
            {
                Recipe r = recipeArray[i]; 
                if (r != null)
                {
                    result[j] = r.ToString();
                    j++; // count number of recipes
                }
            }
            return result;
        }

        /// <summary>
        /// get recipe at specified index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Recipe GetRecipeAt(int index)
        {
            if (CheckIndex(index))
                
                return new Recipe (recipeArray[index]);
            else
                return null;
        }

        /// <summary>
        /// change recipe at specified index
        /// </summary>
        /// <param name="index"></param>
        /// <param name="name"></param>
        /// <param name="category"></param>
        /// <param name="ingredientArray"></param>
        /// <param name="description"></param>
        /// <returns></returns>
        //public bool ChangeRecipe(int index, string name, FoodCategory category, 
        //    string[] ingredientArray, string description)
        //{
        //    if (CheckIndex(index))
        //    {
        //        DeleteRecipe(index);
        //        Recipe recipe = new Recipe(ingredientArray.Length);
        //        recipe.Name = name;
        //        recipe.Category = category;
        //        recipe.Description = description;

        //        for (int i = 0; i < ingredientArray.Length; i++)
        //        {
        //            recipe.Ingredients[i] = ingredientArray[i];
        //        }

        //        recipeArray[index] = recipe; // add recipe to array
        //        return true;
        //    }
        //    return false;
        //}

        /// <summary>
        /// change recipe at specified index
        /// </summary>
        public bool ChangeRecipe(int index, Recipe recipe)
        {
            if (CheckIndex(index))
            {
                DeleteRecipe(index);
                recipeArray[index] = new Recipe(recipe); // add recipe to array
                return true;
            }
            return false;
        }

        /// <summary>
        /// delte recipe at specified index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool DeleteRecipe(int index)
        {
            if (CheckIndex(index))
            {
                recipeArray[index] = null;
                return true;
            }
            return false;
        } 
    }
}