using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook
{
    public class Cookbook
    {
        public List<Recipe> RecipeList = new List<Recipe>();

        public void AddRecipe(Recipe recipe) => RecipeList.Add(recipe);

        public void Example()
        {
            
        }
        
    }
}
