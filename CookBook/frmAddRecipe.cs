using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;


namespace CookBook
{
    public partial class frmAddRecipe : Form
    {
        public Cookbook _cookbook;
        public frmAddRecipe()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btnAddRecipe_Click(object sender, EventArgs e)
        {
            if (!File.Exists("cookbook.json"))
            {
                _cookbook = new Cookbook();
                Recipe recipe = new Recipe(txtName.Text, txtIngredients.Text, txtRecipeContent.Text, txtComments.Text);
                _cookbook.AddRecipe(recipe);
                var cookbookSerialized = JsonConvert.SerializeObject(_cookbook);
                File.WriteAllText("cookbook.json", cookbookSerialized);
            }
            else
            {
                _cookbook = JsonConvert.DeserializeObject<Cookbook>(File.ReadAllText("cookbook.json"));
                Recipe recipe = new Recipe(txtName.Text, txtIngredients.Text, txtRecipeContent.Text, txtComments.Text);
                _cookbook.AddRecipe(recipe);
                var cookbookSerialized = JsonConvert.SerializeObject(_cookbook);
                File.WriteAllText("cookbook.json", cookbookSerialized);                
                this.Close();

            }
           
            
        }

        public void frmRecipe_Load(object sender, EventArgs e)
        {
            
        }
    }
}
