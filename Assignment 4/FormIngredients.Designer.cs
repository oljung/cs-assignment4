namespace Assignment_4
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
            this.gboxIngredient = new System.Windows.Forms.GroupBox();
            this.btnDeleteIngredient = new System.Windows.Forms.Button();
            this.btnEditIngredient = new System.Windows.Forms.Button();
            this.btnAddIngredient = new System.Windows.Forms.Button();
            this.lboxIngredients = new System.Windows.Forms.ListBox();
            this.txtIngredient = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblNumOfIngredients = new System.Windows.Forms.Label();
            this.lblNumOfIngredientOutput = new System.Windows.Forms.Label();
            this.gboxIngredient.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxIngredient
            // 
            this.gboxIngredient.Controls.Add(this.btnDeleteIngredient);
            this.gboxIngredient.Controls.Add(this.btnEditIngredient);
            this.gboxIngredient.Controls.Add(this.btnAddIngredient);
            this.gboxIngredient.Controls.Add(this.lboxIngredients);
            this.gboxIngredient.Controls.Add(this.txtIngredient);
            this.gboxIngredient.Location = new System.Drawing.Point(12, 62);
            this.gboxIngredient.Name = "gboxIngredient";
            this.gboxIngredient.Size = new System.Drawing.Size(463, 348);
            this.gboxIngredient.TabIndex = 0;
            this.gboxIngredient.TabStop = false;
            this.gboxIngredient.Text = "Ingredients";
            // 
            // btnDeleteIngredient
            // 
            this.btnDeleteIngredient.Location = new System.Drawing.Point(385, 122);
            this.btnDeleteIngredient.Name = "btnDeleteIngredient";
            this.btnDeleteIngredient.Size = new System.Drawing.Size(72, 30);
            this.btnDeleteIngredient.TabIndex = 4;
            this.btnDeleteIngredient.Text = "Delete";
            this.btnDeleteIngredient.UseVisualStyleBackColor = true;
            this.btnDeleteIngredient.Click += new System.EventHandler(this.btnDeleteIngredient_Click);
            // 
            // btnEditIngredient
            // 
            this.btnEditIngredient.Location = new System.Drawing.Point(385, 87);
            this.btnEditIngredient.Name = "btnEditIngredient";
            this.btnEditIngredient.Size = new System.Drawing.Size(72, 29);
            this.btnEditIngredient.TabIndex = 3;
            this.btnEditIngredient.Text = "Edit";
            this.btnEditIngredient.UseVisualStyleBackColor = true;
            this.btnEditIngredient.Click += new System.EventHandler(this.btnEditIngredient_Click);
            // 
            // btnAddIngredient
            // 
            this.btnAddIngredient.Location = new System.Drawing.Point(384, 52);
            this.btnAddIngredient.Name = "btnAddIngredient";
            this.btnAddIngredient.Size = new System.Drawing.Size(73, 29);
            this.btnAddIngredient.TabIndex = 2;
            this.btnAddIngredient.Text = "Add";
            this.btnAddIngredient.UseVisualStyleBackColor = true;
            this.btnAddIngredient.Click += new System.EventHandler(this.btnAddIngredient_Click);
            // 
            // lboxIngredients
            // 
            this.lboxIngredients.FormattingEnabled = true;
            this.lboxIngredients.Location = new System.Drawing.Point(6, 52);
            this.lboxIngredients.Name = "lboxIngredients";
            this.lboxIngredients.Size = new System.Drawing.Size(370, 290);
            this.lboxIngredients.TabIndex = 1;
            this.lboxIngredients.SelectedIndexChanged += new System.EventHandler(this.lboxIngredients_SelectedIndexChanged);
            // 
            // txtIngredient
            // 
            this.txtIngredient.Location = new System.Drawing.Point(6, 19);
            this.txtIngredient.Name = "txtIngredient";
            this.txtIngredient.Size = new System.Drawing.Size(370, 20);
            this.txtIngredient.TabIndex = 0;
            this.txtIngredient.Text = "Add ingredient";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(21, 416);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(126, 35);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(269, 416);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 35);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblNumOfIngredients
            // 
            this.lblNumOfIngredients.AutoSize = true;
            this.lblNumOfIngredients.Location = new System.Drawing.Point(18, 34);
            this.lblNumOfIngredients.Name = "lblNumOfIngredients";
            this.lblNumOfIngredients.Size = new System.Drawing.Size(110, 13);
            this.lblNumOfIngredients.TabIndex = 3;
            this.lblNumOfIngredients.Text = "Number of ingredients";
            // 
            // lblNumOfIngredientOutput
            // 
            this.lblNumOfIngredientOutput.AutoSize = true;
            this.lblNumOfIngredientOutput.Location = new System.Drawing.Point(440, 34);
            this.lblNumOfIngredientOutput.Name = "lblNumOfIngredientOutput";
            this.lblNumOfIngredientOutput.Size = new System.Drawing.Size(42, 13);
            this.lblNumOfIngredientOutput.TabIndex = 4;
            this.lblNumOfIngredientOutput.Text = "number";
            // 
            // FormIngredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 463);
            this.Controls.Add(this.lblNumOfIngredientOutput);
            this.Controls.Add(this.lblNumOfIngredients);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gboxIngredient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormIngredients";
            this.Text = "FormIngredients";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormIngredients_FormClosing);
            this.gboxIngredient.ResumeLayout(false);
            this.gboxIngredient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxIngredient;
        private System.Windows.Forms.Button btnDeleteIngredient;
        private System.Windows.Forms.Button btnEditIngredient;
        private System.Windows.Forms.Button btnAddIngredient;
        private System.Windows.Forms.ListBox lboxIngredients;
        private System.Windows.Forms.TextBox txtIngredient;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblNumOfIngredients;
        private System.Windows.Forms.Label lblNumOfIngredientOutput;
    }
}