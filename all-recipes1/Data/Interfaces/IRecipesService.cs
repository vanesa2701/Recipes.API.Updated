using all_recipes1.Data.ViewModels;
using System.Collections.Generic;
using System.Linq;
using all_recipes1.Data.Models;
using all_recipes1.Data.ViewModels;
namespace all_recipes1.Data.Interfaces
{
    public interface IRecipesService
    {
        void AddRecipe(RecipeVM recipe);
        
            public string Name { get; set; }
        public string Description { get; set; }
        public int Rate { get; set; }

        List<Recipe> GetAllRecipes();
        Recipe GetRecipeById(int recipeId);
        void DeleteRecipeById(int id);
        Recipe UpdateRecipeById(int recipeId, RecipeVM recipe);
    }
}
