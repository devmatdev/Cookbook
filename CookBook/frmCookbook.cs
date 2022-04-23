using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CookBook
{
    
    public partial class frmCookbook : Form
    {
        public Cookbook _cookbook;
       
        
        public frmCookbook()
        {
            //zastanowic sie czy to musi byc w konstruktorze bo w load tez dziala
            if (!File.Exists("cookbook.json"))
            {

            }
            else
            {
                _cookbook = JsonConvert.DeserializeObject<Cookbook>(File.ReadAllText("cookbook.json"));
            }

            InitializeComponent();
            
        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            frmAddRecipe frmAddRecipe = new frmAddRecipe();
            frmAddRecipe.Show();
           
        }

        private void frmCookbook_Load(object sender, EventArgs e)
        {
      
            foreach (var recipe in _cookbook.RecipeList)
            {
                lstRecipes.Items.Add(recipe.Name.ToString());
            }
        }
       
        private void btnRemoveRecipe_Click(object sender, EventArgs e)
        {
            _cookbook.RemoveRecipe(lstRecipes.SelectedItem.ToString());
            var cookbookSerialized = JsonConvert.SerializeObject(_cookbook);
            File.WriteAllText("cookbook.json", cookbookSerialized);
            lstRecipes.Items.Remove(lstRecipes.SelectedItem);
        }
    }
}
