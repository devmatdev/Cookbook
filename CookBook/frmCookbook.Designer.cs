
namespace CookBook
{
    partial class frmCookbook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnShowRecipe = new System.Windows.Forms.Button();
            this.btnAddRecipe = new System.Windows.Forms.Button();
            this.btnRemoveRecipe = new System.Windows.Forms.Button();
            this.btnEditRecipe = new System.Windows.Forms.Button();
            this.lstRecipes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnShowRecipe
            // 
            this.btnShowRecipe.Location = new System.Drawing.Point(246, 12);
            this.btnShowRecipe.Name = "btnShowRecipe";
            this.btnShowRecipe.Size = new System.Drawing.Size(92, 34);
            this.btnShowRecipe.TabIndex = 1;
            this.btnShowRecipe.Text = "Pokaż przepis";
            this.btnShowRecipe.UseVisualStyleBackColor = true;
            // 
            // btnAddRecipe
            // 
            this.btnAddRecipe.Location = new System.Drawing.Point(246, 52);
            this.btnAddRecipe.Name = "btnAddRecipe";
            this.btnAddRecipe.Size = new System.Drawing.Size(92, 34);
            this.btnAddRecipe.TabIndex = 1;
            this.btnAddRecipe.Text = "Dodaj przepis";
            this.btnAddRecipe.UseVisualStyleBackColor = true;
            this.btnAddRecipe.Click += new System.EventHandler(this.btnAddRecipe_Click);
            // 
            // btnRemoveRecipe
            // 
            this.btnRemoveRecipe.Location = new System.Drawing.Point(246, 132);
            this.btnRemoveRecipe.Name = "btnRemoveRecipe";
            this.btnRemoveRecipe.Size = new System.Drawing.Size(92, 34);
            this.btnRemoveRecipe.TabIndex = 1;
            this.btnRemoveRecipe.Text = "Usuń przepis";
            this.btnRemoveRecipe.UseVisualStyleBackColor = true;
            this.btnRemoveRecipe.Click += new System.EventHandler(this.btnRemoveRecipe_Click);
            // 
            // btnEditRecipe
            // 
            this.btnEditRecipe.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEditRecipe.Location = new System.Drawing.Point(246, 92);
            this.btnEditRecipe.Name = "btnEditRecipe";
            this.btnEditRecipe.Size = new System.Drawing.Size(92, 34);
            this.btnEditRecipe.TabIndex = 1;
            this.btnEditRecipe.Text = "Edytuj przepis";
            this.btnEditRecipe.UseVisualStyleBackColor = true;
            // 
            // lstRecipes
            // 
            this.lstRecipes.FormattingEnabled = true;
            this.lstRecipes.ItemHeight = 15;
            this.lstRecipes.Location = new System.Drawing.Point(12, 12);
            this.lstRecipes.Name = "lstRecipes";
            this.lstRecipes.Size = new System.Drawing.Size(183, 424);
            this.lstRecipes.TabIndex = 2;
            // 
            // frmCookbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstRecipes);
            this.Controls.Add(this.btnEditRecipe);
            this.Controls.Add(this.btnRemoveRecipe);
            this.Controls.Add(this.btnAddRecipe);
            this.Controls.Add(this.btnShowRecipe);
            this.Name = "frmCookbook";
            this.Text = "frmCookbook";
            this.Load += new System.EventHandler(this.frmCookbook_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnShowRecipe;
        private System.Windows.Forms.Button btnAddRecipe;
        private System.Windows.Forms.Button btnRemoveRecipe;
        private System.Windows.Forms.Button btnEditRecipe;
        private System.Windows.Forms.ListBox lstRecipes;
    }
}