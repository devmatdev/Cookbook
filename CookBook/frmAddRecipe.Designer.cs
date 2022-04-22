
namespace CookBook
{
    partial class frmAddRecipe
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtIngredients = new System.Windows.Forms.RichTextBox();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.txtRecipeContent = new System.Windows.Forms.RichTextBox();
            this.lblRecipeContent = new System.Windows.Forms.Label();
            this.txtComments = new System.Windows.Forms.RichTextBox();
            this.lblComments = new System.Windows.Forms.Label();
            this.btnAddRecipe = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 36);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(243, 23);
            this.txtName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(92, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nazwa przepisu:";
            // 
            // txtIngredients
            // 
            this.txtIngredients.Location = new System.Drawing.Point(12, 99);
            this.txtIngredients.Name = "txtIngredients";
            this.txtIngredients.Size = new System.Drawing.Size(243, 283);
            this.txtIngredients.TabIndex = 2;
            this.txtIngredients.Text = "";
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Location = new System.Drawing.Point(13, 78);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(57, 15);
            this.lblIngredients.TabIndex = 3;
            this.lblIngredients.Text = "Składniki:";
            // 
            // txtRecipeContent
            // 
            this.txtRecipeContent.Location = new System.Drawing.Point(296, 36);
            this.txtRecipeContent.Name = "txtRecipeContent";
            this.txtRecipeContent.Size = new System.Drawing.Size(492, 346);
            this.txtRecipeContent.TabIndex = 4;
            this.txtRecipeContent.Text = "";
            // 
            // lblRecipeContent
            // 
            this.lblRecipeContent.AutoSize = true;
            this.lblRecipeContent.Location = new System.Drawing.Point(296, 18);
            this.lblRecipeContent.Name = "lblRecipeContent";
            this.lblRecipeContent.Size = new System.Drawing.Size(69, 15);
            this.lblRecipeContent.TabIndex = 5;
            this.lblRecipeContent.Text = "Wykonanie:";
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(12, 421);
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(362, 81);
            this.txtComments.TabIndex = 6;
            this.txtComments.Text = "";
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(13, 403);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(43, 15);
            this.lblComments.TabIndex = 7;
            this.lblComments.Text = "Uwagi:";
            // 
            // btnAddRecipe
            // 
            this.btnAddRecipe.AutoSize = true;
            this.btnAddRecipe.Location = new System.Drawing.Point(700, 421);
            this.btnAddRecipe.Name = "btnAddRecipe";
            this.btnAddRecipe.Size = new System.Drawing.Size(88, 25);
            this.btnAddRecipe.TabIndex = 8;
            this.btnAddRecipe.Text = "Dodaj przepis";
            this.btnAddRecipe.UseVisualStyleBackColor = true;
            this.btnAddRecipe.Click += new System.EventHandler(this.btnAddRecipe_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(700, 452);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddRecipe);
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.lblRecipeContent);
            this.Controls.Add(this.txtRecipeContent);
            this.Controls.Add(this.lblIngredients);
            this.Controls.Add(this.txtIngredients);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Name = "frmRecipe";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmRecipe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.RichTextBox txtIngredients;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.RichTextBox txtRecipeContent;
        private System.Windows.Forms.Label lblRecipeContent;
        private System.Windows.Forms.RichTextBox txtComments;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.Button btnAddRecipe;
        private System.Windows.Forms.Button btnCancel;
    }
}

