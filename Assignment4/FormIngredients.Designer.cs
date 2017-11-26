namespace Assignment4
{
    partial class FormIngredients
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
            this.components = new System.ComponentModel.Container();
            this.txtIngredient = new System.Windows.Forms.TextBox();
            this.gboIngredientsList = new System.Windows.Forms.GroupBox();
            this.btnDeleteIngr = new System.Windows.Forms.Button();
            this.btnEditIngr = new System.Windows.Forms.Button();
            this.lblNumOfIngredients = new System.Windows.Forms.Label();
            this.lstIngredients = new System.Windows.Forms.ListBox();
            this.lblNumOfIngredientsText = new System.Windows.Forms.Label();
            this.gboIngredient = new System.Windows.Forms.GroupBox();
            this.btnAddIngr = new System.Windows.Forms.Button();
            this.btnEndAddIngr = new System.Windows.Forms.Button();
            this.btnCancelAddIngr = new System.Windows.Forms.Button();
            this.toolTipIngredient = new System.Windows.Forms.ToolTip(this.components);
            this.gboIngredientsList.SuspendLayout();
            this.gboIngredient.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIngredient
            // 
            this.txtIngredient.Location = new System.Drawing.Point(11, 31);
            this.txtIngredient.Name = "txtIngredient";
            this.txtIngredient.Size = new System.Drawing.Size(595, 22);
            this.txtIngredient.TabIndex = 0;
            this.txtIngredient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIngredient_KeyPress);
            // 
            // gboIngredientsList
            // 
            this.gboIngredientsList.Controls.Add(this.btnDeleteIngr);
            this.gboIngredientsList.Controls.Add(this.btnEditIngr);
            this.gboIngredientsList.Controls.Add(this.lblNumOfIngredients);
            this.gboIngredientsList.Controls.Add(this.lstIngredients);
            this.gboIngredientsList.Controls.Add(this.lblNumOfIngredientsText);
            this.gboIngredientsList.Location = new System.Drawing.Point(111, 150);
            this.gboIngredientsList.Name = "gboIngredientsList";
            this.gboIngredientsList.Size = new System.Drawing.Size(773, 216);
            this.gboIngredientsList.TabIndex = 3;
            this.gboIngredientsList.TabStop = false;
            this.gboIngredientsList.Text = "Ingredients list";
            // 
            // btnDeleteIngr
            // 
            this.btnDeleteIngr.Location = new System.Drawing.Point(623, 118);
            this.btnDeleteIngr.Name = "btnDeleteIngr";
            this.btnDeleteIngr.Size = new System.Drawing.Size(133, 33);
            this.btnDeleteIngr.TabIndex = 10;
            this.btnDeleteIngr.Text = "Delete ingredient";
            this.btnDeleteIngr.UseVisualStyleBackColor = true;
            this.btnDeleteIngr.Click += new System.EventHandler(this.btnDeleteIngr_Click);
            // 
            // btnEditIngr
            // 
            this.btnEditIngr.Location = new System.Drawing.Point(623, 62);
            this.btnEditIngr.Name = "btnEditIngr";
            this.btnEditIngr.Size = new System.Drawing.Size(133, 33);
            this.btnEditIngr.TabIndex = 9;
            this.btnEditIngr.Text = "Update ingredient";
            this.btnEditIngr.UseVisualStyleBackColor = true;
            this.btnEditIngr.Click += new System.EventHandler(this.btnEditIngr_Click);
            // 
            // lblNumOfIngredients
            // 
            this.lblNumOfIngredients.AutoSize = true;
            this.lblNumOfIngredients.Location = new System.Drawing.Point(176, 33);
            this.lblNumOfIngredients.Name = "lblNumOfIngredients";
            this.lblNumOfIngredients.Size = new System.Drawing.Size(16, 17);
            this.lblNumOfIngredients.TabIndex = 8;
            this.lblNumOfIngredients.Text = "0";
            // 
            // lstIngredients
            // 
            this.lstIngredients.FormattingEnabled = true;
            this.lstIngredients.ItemHeight = 16;
            this.lstIngredients.Location = new System.Drawing.Point(11, 62);
            this.lstIngredients.Name = "lstIngredients";
            this.lstIngredients.Size = new System.Drawing.Size(595, 132);
            this.lstIngredients.TabIndex = 0;
            this.lstIngredients.SelectedIndexChanged += new System.EventHandler(this.lstIngredients_SelectedIndexChanged);
            // 
            // lblNumOfIngredientsText
            // 
            this.lblNumOfIngredientsText.AutoSize = true;
            this.lblNumOfIngredientsText.Location = new System.Drawing.Point(8, 33);
            this.lblNumOfIngredientsText.Name = "lblNumOfIngredientsText";
            this.lblNumOfIngredientsText.Size = new System.Drawing.Size(148, 17);
            this.lblNumOfIngredientsText.TabIndex = 7;
            this.lblNumOfIngredientsText.Text = "Number of ingredients";
            // 
            // gboIngredient
            // 
            this.gboIngredient.Controls.Add(this.btnAddIngr);
            this.gboIngredient.Controls.Add(this.txtIngredient);
            this.gboIngredient.Location = new System.Drawing.Point(111, 57);
            this.gboIngredient.Name = "gboIngredient";
            this.gboIngredient.Size = new System.Drawing.Size(773, 82);
            this.gboIngredient.TabIndex = 4;
            this.gboIngredient.TabStop = false;
            this.gboIngredient.Text = "Add ingredient";
            // 
            // btnAddIngr
            // 
            this.btnAddIngr.Location = new System.Drawing.Point(623, 26);
            this.btnAddIngr.Name = "btnAddIngr";
            this.btnAddIngr.Size = new System.Drawing.Size(133, 33);
            this.btnAddIngr.TabIndex = 1;
            this.btnAddIngr.Text = "Add ingredient";
            this.btnAddIngr.UseVisualStyleBackColor = true;
            this.btnAddIngr.Click += new System.EventHandler(this.btnAddIngr_Click);
            // 
            // btnEndAddIngr
            // 
            this.btnEndAddIngr.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEndAddIngr.Location = new System.Drawing.Point(122, 382);
            this.btnEndAddIngr.Name = "btnEndAddIngr";
            this.btnEndAddIngr.Size = new System.Drawing.Size(157, 43);
            this.btnEndAddIngr.TabIndex = 5;
            this.btnEndAddIngr.Text = "End adding ingredients";
            this.btnEndAddIngr.UseVisualStyleBackColor = true;
            this.btnEndAddIngr.Click += new System.EventHandler(this.btnEndAddIngr_Click);
            // 
            // btnCancelAddIngr
            // 
            this.btnCancelAddIngr.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelAddIngr.Location = new System.Drawing.Point(290, 382);
            this.btnCancelAddIngr.Name = "btnCancelAddIngr";
            this.btnCancelAddIngr.Size = new System.Drawing.Size(157, 43);
            this.btnCancelAddIngr.TabIndex = 6;
            this.btnCancelAddIngr.Text = "Cancel adding ingredients";
            this.btnCancelAddIngr.UseVisualStyleBackColor = true;
            this.btnCancelAddIngr.Click += new System.EventHandler(this.btnCancelAddIngr_Click);
            // 
            // FormIngredients
            // 
            this.ClientSize = new System.Drawing.Size(1164, 620);
            this.Controls.Add(this.btnCancelAddIngr);
            this.Controls.Add(this.btnEndAddIngr);
            this.Controls.Add(this.gboIngredient);
            this.Controls.Add(this.gboIngredientsList);
            this.Name = "FormIngredients";
            this.gboIngredientsList.ResumeLayout(false);
            this.gboIngredientsList.PerformLayout();
            this.gboIngredient.ResumeLayout(false);
            this.gboIngredient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNumOfIngredientsText;
        private System.Windows.Forms.Label lblNumOfIngredients;
        private System.Windows.Forms.GroupBox gboIngredient;
        private System.Windows.Forms.TextBox txtIngredient;
        private System.Windows.Forms.Button btnAddIngr;
        private System.Windows.Forms.GroupBox gboIngredientsList;
        private System.Windows.Forms.ListBox lstIngredients;
        private System.Windows.Forms.Button btnEndAddIngr;
        private System.Windows.Forms.Button btnCancelAddIngr;
        private System.Windows.Forms.ToolTip toolTipIngredient;
        private System.Windows.Forms.Button btnDeleteIngr;
        private System.Windows.Forms.Button btnEditIngr;
    }
}