namespace Assignment_4
{
    partial class MainForm
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
            this.gboxNewRecipe = new System.Windows.Forms.GroupBox();
            this.btnAddRecipe = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAddIngredients = new System.Windows.Forms.Button();
            this.cboxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtNameOfRecipe = new System.Windows.Forms.TextBox();
            this.lblRecipeName = new System.Windows.Forms.Label();
            this.lboxRecipeList = new System.Windows.Forms.ListBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCategoryList = new System.Windows.Forms.Label();
            this.lblNrOfIngredients = new System.Windows.Forms.Label();
            this.gboxEdit = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gboxNewRecipe.SuspendLayout();
            this.gboxEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxNewRecipe
            // 
            this.gboxNewRecipe.Controls.Add(this.btnAddRecipe);
            this.gboxNewRecipe.Controls.Add(this.txtDescription);
            this.gboxNewRecipe.Controls.Add(this.btnAddIngredients);
            this.gboxNewRecipe.Controls.Add(this.cboxCategory);
            this.gboxNewRecipe.Controls.Add(this.lblCategory);
            this.gboxNewRecipe.Controls.Add(this.txtNameOfRecipe);
            this.gboxNewRecipe.Controls.Add(this.lblRecipeName);
            this.gboxNewRecipe.Location = new System.Drawing.Point(14, 15);
            this.gboxNewRecipe.Name = "gboxNewRecipe";
            this.gboxNewRecipe.Size = new System.Drawing.Size(388, 541);
            this.gboxNewRecipe.TabIndex = 0;
            this.gboxNewRecipe.TabStop = false;
            this.gboxNewRecipe.Text = "Add new recipe";
            // 
            // btnAddRecipe
            // 
            this.btnAddRecipe.Location = new System.Drawing.Point(102, 419);
            this.btnAddRecipe.Name = "btnAddRecipe";
            this.btnAddRecipe.Size = new System.Drawing.Size(176, 44);
            this.btnAddRecipe.TabIndex = 6;
            this.btnAddRecipe.Text = "Add Recipe";
            this.btnAddRecipe.UseVisualStyleBackColor = true;
            this.btnAddRecipe.Click += new System.EventHandler(this.btnAddRecipe_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(6, 79);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(376, 305);
            this.txtDescription.TabIndex = 5;
            // 
            // btnAddIngredients
            // 
            this.btnAddIngredients.Location = new System.Drawing.Point(227, 43);
            this.btnAddIngredients.Name = "btnAddIngredients";
            this.btnAddIngredients.Size = new System.Drawing.Size(142, 30);
            this.btnAddIngredients.TabIndex = 4;
            this.btnAddIngredients.Text = "Add Ingredients";
            this.btnAddIngredients.UseVisualStyleBackColor = true;
            this.btnAddIngredients.Click += new System.EventHandler(this.btnAddIngredients_Click);
            // 
            // cboxCategory
            // 
            this.cboxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCategory.FormattingEnabled = true;
            this.cboxCategory.Location = new System.Drawing.Point(68, 49);
            this.cboxCategory.Name = "cboxCategory";
            this.cboxCategory.Size = new System.Drawing.Size(127, 21);
            this.cboxCategory.TabIndex = 3;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(13, 52);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category";
            // 
            // txtNameOfRecipe
            // 
            this.txtNameOfRecipe.Location = new System.Drawing.Point(102, 19);
            this.txtNameOfRecipe.Name = "txtNameOfRecipe";
            this.txtNameOfRecipe.Size = new System.Drawing.Size(280, 20);
            this.txtNameOfRecipe.TabIndex = 1;
            // 
            // lblRecipeName
            // 
            this.lblRecipeName.AutoSize = true;
            this.lblRecipeName.Location = new System.Drawing.Point(13, 26);
            this.lblRecipeName.Name = "lblRecipeName";
            this.lblRecipeName.Size = new System.Drawing.Size(79, 13);
            this.lblRecipeName.TabIndex = 0;
            this.lblRecipeName.Text = "Name of recipe";
            // 
            // lboxRecipeList
            // 
            this.lboxRecipeList.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboxRecipeList.FormattingEnabled = true;
            this.lboxRecipeList.ItemHeight = 14;
            this.lboxRecipeList.Location = new System.Drawing.Point(423, 57);
            this.lboxRecipeList.Name = "lboxRecipeList";
            this.lboxRecipeList.Size = new System.Drawing.Size(428, 340);
            this.lboxRecipeList.TabIndex = 1;
            this.lboxRecipeList.DoubleClick += new System.EventHandler(this.lboxRecipeList_DoubleClick);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(420, 41);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // lblCategoryList
            // 
            this.lblCategoryList.AutoSize = true;
            this.lblCategoryList.Location = new System.Drawing.Point(603, 37);
            this.lblCategoryList.Name = "lblCategoryList";
            this.lblCategoryList.Size = new System.Drawing.Size(49, 13);
            this.lblCategoryList.TabIndex = 3;
            this.lblCategoryList.Text = "Category";
            // 
            // lblNrOfIngredients
            // 
            this.lblNrOfIngredients.AutoSize = true;
            this.lblNrOfIngredients.Location = new System.Drawing.Point(761, 34);
            this.lblNrOfIngredients.Name = "lblNrOfIngredients";
            this.lblNrOfIngredients.Size = new System.Drawing.Size(90, 13);
            this.lblNrOfIngredients.TabIndex = 4;
            this.lblNrOfIngredients.Text = "Nr. Of Ingredients";
            // 
            // gboxEdit
            // 
            this.gboxEdit.Controls.Add(this.btnCancel);
            this.gboxEdit.Controls.Add(this.btnSave);
            this.gboxEdit.Controls.Add(this.btnSelect);
            this.gboxEdit.Location = new System.Drawing.Point(423, 404);
            this.gboxEdit.Name = "gboxEdit";
            this.gboxEdit.Size = new System.Drawing.Size(181, 86);
            this.gboxEdit.TabIndex = 5;
            this.gboxEdit.TabStop = false;
            this.gboxEdit.Text = "Edit recipe";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(97, 50);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 33);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, 50);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 33);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(6, 19);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(167, 25);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(610, 423);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 25);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(747, 424);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear Selection";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 490);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gboxEdit);
            this.Controls.Add(this.lblNrOfIngredients);
            this.Controls.Add(this.lblCategoryList);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lboxRecipeList);
            this.Controls.Add(this.gboxNewRecipe);
            this.Name = "MainForm";
            this.Text = "Recipe Book by Patrik Österljung";
            this.gboxNewRecipe.ResumeLayout(false);
            this.gboxNewRecipe.PerformLayout();
            this.gboxEdit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxNewRecipe;
        private System.Windows.Forms.ComboBox cboxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtNameOfRecipe;
        private System.Windows.Forms.Label lblRecipeName;
        private System.Windows.Forms.Button btnAddRecipe;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAddIngredients;
        private System.Windows.Forms.ListBox lboxRecipeList;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCategoryList;
        private System.Windows.Forms.Label lblNrOfIngredients;
        private System.Windows.Forms.GroupBox gboxEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
    }
}

