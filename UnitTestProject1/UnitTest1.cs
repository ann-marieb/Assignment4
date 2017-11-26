using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment4;

namespace UnitTestProject1
{
    [TestClass]
    public class RecipeTest
    {
        [TestMethod]
        public void Create_a_recipe()
        {
            Recipe recipe = new Recipe(3);
            recipe.AddIngredient("mjöl");
            Assert.AreEqual(1, recipe.GetCurrentNumOfIngredients());
        }

        [TestMethod]
        public void xxe_a_recipe()
        {
            Recipe recipe = new Recipe(3);
            recipe.AddIngredient("mjöl");
            Assert.AreEqual(1, recipe.GetCurrentNumOfIngredients());
        }


    }

    [TestClass]
    public class RecipeManagerTests
    {
        [TestMethod]
        public void add_a_recipe()
        {
            var rm = new RecipeManager(3);


            rm.Add("Pölsa", FoodCategory.Meat, new string[] { "ett", "två" }, "desc");
            rm.Add("vego", FoodCategory.Vegetarian, new string[] { "sallad", "två" }, "hacka");

            var antal = rm.GetCurrentNumOfRecipes();
            Assert.AreEqual(2, rm.GetCurrentNumOfRecipes());
            Assert.AreEqual("vego", rm.GetRecipeAt(1).Name);
        }

        [TestMethod]
        public void change_a_recipe()
        {
            // SEtup
            var rm = new RecipeManager(3);

            rm.Add("Pölsa", FoodCategory.Meat, new string[] { "ett", "två" }, "desc");
            rm.Add("vego", FoodCategory.Vegetarian, new string[] { "sallad", "två" }, "hacka");

            // Exercise
            rm.ChangeRecipe(0, "Pölsa2", FoodCategory.Meat, new string[] { "ett", "två" }, "desc");
            Assert.AreEqual("Pölsa2", rm.GetRecipeAt(0).Name);
            Assert.AreEqual("vego", rm.GetRecipeAt(1).Name);
        }
    }

}
