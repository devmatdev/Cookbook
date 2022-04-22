using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook
{
    
    public class Recipe
    {
        
        public string Name { get; set; }
        public string Ingredients { get; set; }
        public string RecipeContent { get; set; }
        public string Comments { get; set; }
        

        public Recipe(string name, string ingredients, string recipeContent, string comments)
        {
            this.Name = name;
            this.Ingredients = ingredients;
            this.RecipeContent = recipeContent;
            this.Comments = comments;
        }
    }
}
