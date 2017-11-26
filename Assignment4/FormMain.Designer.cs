namespace Assignment4
{
    partial class FormMain
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
            this.gbxAddNewRecipe = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAddIngredients = new System.Windows.Forms.Button();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtNameOfRecipe = new System.Windows.Forms.TextBox();
            this.lblNameOfRecipe = new System.Windows.Forms.Label();
            this.btnAddRecipe = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNoOfIngredients = new System.Windows.Forms.Label();
            this.lblCategory2 = new System.Windows.Forms.Label();
            this.lblDescription2 = new System.Windows.Forms.Label();
            this.lstRecipeList = new System.Windows.Forms.ListBox();
            this.lblNoOfRecipesText = new System.Windows.Forms.Label();
            this.lblNumOfRecipes = new System.Windows.Forms.Label();
            this.btnUpdateRecipe = new System.Windows.Forms.Button();
            this.btnDeleteRecipe = new System.Windows.Forms.Button();
            this.gbxAddNewRecipe.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxAddNewRecipe
            // 
            this.gbxAddNewRecipe.Controls.Add(this.txtDescription);
            this.gbxAddNewRecipe.Controls.Add(this.btnAddIngredients);
            this.gbxAddNewRecipe.Controls.Add(this.cboCategory);
            this.gbxAddNewRecipe.Controls.Add(this.lblCategory);
            this.gbxAddNewRecipe.Controls.Add(this.txtNameOfRecipe);
            this.gbxAddNewRecipe.Controls.Add(this.lblNameOfRecipe);
            this.gbxAddNewRecipe.Location = new System.Drawing.Point(30, 40);
            this.gbxAddNewRecipe.Name = "gbxAddNewRecipe";
            this.gbxAddNewRecipe.Size = new System.Drawing.Size(502, 493);
            this.gbxAddNewRecipe.TabIndex = 0;
            this.gbxAddNewRecipe.TabStop = false;
            this.gbxAddNewRecipe.Text = "Recipe";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(25, 145);
            this.txtDescription.MinimumSize = new System.Drawing.Size(4, 100);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(458, 329);
            this.txtDescription.TabIndex = 5;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // btnAddIngredients
            // 
            this.btnAddIngredients.Location = new System.Drawing.Point(310, 87);
            this.btnAddIngredients.Name = "btnAddIngredients";
            this.btnAddIngredients.Size = new System.Drawing.Size(174, 31);
            this.btnAddIngredients.TabIndex = 4;
            this.btnAddIngredients.Text = "Edit ingredients";
            this.btnAddIngredients.UseVisualStyleBackColor = true;
            this.btnAddIngredients.Click += new System.EventHandler(this.btnEditIngredients_Click);
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(135, 87);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(121, 24);
            this.cboCategory.TabIndex = 3;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(20, 94);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(65, 17);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category";
            // 
            // txtNameOfRecipe
            // 
            this.txtNameOfRecipe.Location = new System.Drawing.Point(135, 39);
            this.txtNameOfRecipe.Name = "txtNameOfRecipe";
            this.txtNameOfRecipe.Size = new System.Drawing.Size(350, 22);
            this.txtNameOfRecipe.TabIndex = 1;
            this.txtNameOfRecipe.TextChanged += new System.EventHandler(this.txtNameOfRecipe_TextChanged);
            // 
            // lblNameOfRecipe
            // 
            this.lblNameOfRecipe.AutoSize = true;
            this.lblNameOfRecipe.Location = new System.Drawing.Point(15, 39);
            this.lblNameOfRecipe.Name = "lblNameOfRecipe";
            this.lblNameOfRecipe.Size = new System.Drawing.Size(104, 17);
            this.lblNameOfRecipe.TabIndex = 0;
            this.lblNameOfRecipe.Text = "Name of recipe";
            // 
            // btnAddRecipe
            // 
            this.btnAddRecipe.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddRecipe.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddRecipe.Location = new System.Drawing.Point(56, 552);
            this.btnAddRecipe.Name = "btnAddRecipe";
            this.btnAddRecipe.Size = new System.Drawing.Size(130, 37);
            this.btnAddRecipe.TabIndex = 1;
            this.btnAddRecipe.Text = "Add recipe";
            this.btnAddRecipe.UseVisualStyleBackColor = false;
            this.btnAddRecipe.Click += new System.EventHandler(this.btnAddRecipe_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(557, 67);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // lblNoOfIngredients
            // 
            this.lblNoOfIngredients.AutoSize = true;
            this.lblNoOfIngredients.Location = new System.Drawing.Point(742, 50);
            this.lblNoOfIngredients.Name = "lblNoOfIngredients";
            this.lblNoOfIngredients.Size = new System.Drawing.Size(78, 34);
            this.lblNoOfIngredients.TabIndex = 4;
            this.lblNoOfIngredients.Text = "No. of \r\ningredients";
            // 
            // lblCategory2
            // 
            this.lblCategory2.AutoSize = true;
            this.lblCategory2.Location = new System.Drawing.Point(826, 67);
            this.lblCategory2.Name = "lblCategory2";
            this.lblCategory2.Size = new System.Drawing.Size(65, 17);
            this.lblCategory2.TabIndex = 5;
            this.lblCategory2.Text = "Category";
            // 
            // lblDescription2
            // 
            this.lblDescription2.AutoSize = true;
            this.lblDescription2.Location = new System.Drawing.Point(921, 67);
            this.lblDescription2.Name = "lblDescription2";
            this.lblDescription2.Size = new System.Drawing.Size(79, 17);
            this.lblDescription2.TabIndex = 6;
            this.lblDescription2.Text = "Description";
            // 
            // lstRecipeList
            // 
            this.lstRecipeList.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRecipeList.FormattingEnabled = true;
            this.lstRecipeList.ItemHeight = 16;
            this.lstRecipeList.Location = new System.Drawing.Point(551, 94);
            this.lstRecipeList.Name = "lstRecipeList";
            this.lstRecipeList.Size = new System.Drawing.Size(594, 420);
            this.lstRecipeList.TabIndex = 7;
            this.lstRecipeList.SelectedIndexChanged += new System.EventHandler(this.lstRecipeList_SelectedIndexChanged);
            // 
            // lblNoOfRecipesText
            // 
            this.lblNoOfRecipesText.AutoSize = true;
            this.lblNoOfRecipesText.Location = new System.Drawing.Point(557, 27);
            this.lblNoOfRecipesText.Name = "lblNoOfRecipesText";
            this.lblNoOfRecipesText.Size = new System.Drawing.Size(158, 17);
            this.lblNoOfRecipesText.TabIndex = 8;
            this.lblNoOfRecipesText.Text = "Total number of recipes";
            // 
            // lblNumOfRecipes
            // 
            this.lblNumOfRecipes.AutoSize = true;
            this.lblNumOfRecipes.Location = new System.Drawing.Point(742, 27);
            this.lblNumOfRecipes.Name = "lblNumOfRecipes";
            this.lblNumOfRecipes.Size = new System.Drawing.Size(46, 17);
            this.lblNumOfRecipes.TabIndex = 9;
            this.lblNumOfRecipes.Text = "label1";
            // 
            // btnUpdateRecipe
            // 
            this.btnUpdateRecipe.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnUpdateRecipe.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnUpdateRecipe.Location = new System.Drawing.Point(247, 552);
            this.btnUpdateRecipe.Name = "btnUpdateRecipe";
            this.btnUpdateRecipe.Size = new System.Drawing.Size(130, 37);
            this.btnUpdateRecipe.TabIndex = 10;
            this.btnUpdateRecipe.Text = "Update recipe";
            this.btnUpdateRecipe.UseVisualStyleBackColor = false;
            this.btnUpdateRecipe.Click += new System.EventHandler(this.btnUpdateRecipe_Click);
            // 
            // btnDeleteRecipe
            // 
            this.btnDeleteRecipe.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDeleteRecipe.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDeleteRecipe.Location = new System.Drawing.Point(383, 552);
            this.btnDeleteRecipe.Name = "btnDeleteRecipe";
            this.btnDeleteRecipe.Size = new System.Drawing.Size(130, 37);
            this.btnDeleteRecipe.TabIndex = 11;
            this.btnDeleteRecipe.Text = "Delete recipe";
            this.btnDeleteRecipe.UseVisualStyleBackColor = false;
            this.btnDeleteRecipe.Click += new System.EventHandler(this.btnDeleteRecipe_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 729);
            this.Controls.Add(this.btnDeleteRecipe);
            this.Controls.Add(this.btnUpdateRecipe);
            this.Controls.Add(this.lblNumOfRecipes);
            this.Controls.Add(this.lblNoOfRecipesText);
            this.Controls.Add(this.lstRecipeList);
            this.Controls.Add(this.lblDescription2);
            this.Controls.Add(this.lblCategory2);
            this.Controls.Add(this.lblNoOfIngredients);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnAddRecipe);
            this.Controls.Add(this.gbxAddNewRecipe);
            this.Name = "FormMain";
            this.Text = "FormIngredients";
            this.gbxAddNewRecipe.ResumeLayout(false);
            this.gbxAddNewRecipe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxAddNewRecipe;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtNameOfRecipe;
        private System.Windows.Forms.Label lblNameOfRecipe;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAddIngredients;
        private System.Windows.Forms.Button btnAddRecipe;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNoOfIngredients;
        private System.Windows.Forms.Label lblCategory2;
        private System.Windows.Forms.Label lblDescription2;
        private System.Windows.Forms.ListBox lstRecipeList;
        private System.Windows.Forms.Label lblNoOfRecipesText;
        private System.Windows.Forms.Label lblNumOfRecipes;
        private System.Windows.Forms.Button btnUpdateRecipe;
        private System.Windows.Forms.Button btnDeleteRecipe;
    }
}

