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
        public Cookbook _cookbook = JsonConvert.DeserializeObject<Cookbook>(File.ReadAllText("cookbook.json"));
        
        public frmCookbook()
        {

            InitializeComponent();
            
        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            frmAddRecipe frmAddRecipe = new frmAddRecipe();
            frmAddRecipe.Show();
        }
    }
}
