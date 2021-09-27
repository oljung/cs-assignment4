using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4
{
    partial class FormIngredients : Form
    {

        private Recipe recipe;
        private bool ok;//used to check if ingredients were added before closing
        public FormIngredients(Recipe recipe)
        {
            InitializeComponent();
            this.recipe = recipe;
            UpdateGUI();
        }

        public Recipe Recipe
        {
            get { return recipe; }
        }
        private void UpdateGUI()//updates the GUI by clearing old info and adding new
        {
            lboxIngredients.Items.Clear();
            txtIngredient.Text = string.Empty;//clears ingredient textbox
            lblNumOfIngredientOutput.Text = recipe.NumOfElements.ToString();//displays current number of ingredients
            string[] ingredientlist = recipe.ShowIngredients();//prepares an array with ingredients from private array
            if (ingredientlist != null)//will return null if numOfElements == 0
            {
                lboxIngredients.Items.AddRange(ingredientlist);//adds the ingredient list to listbox
            }
                

        }

        private void btnAddIngredient_Click(object sender, EventArgs e)
        {
            //trims the text from textbox and then passes it to the AddIngredient() method
            string ingredient = txtIngredient.Text.Trim();
            //calls AddIngredient method and checks if operation worked
            bool ok = recipe.AddIngredient(ingredient);
            if (ok)
            {
                //updates the listbox and labels
                UpdateGUI();
            }
            else
                MessageBox.Show("Recipe not added, textbox must contain text", "Error");

        }

        private void btnDeleteIngredient_Click(object sender, EventArgs e)
        {
            //calls the DeleteItem() method with the listbox index as argument
            bool ok = recipe.DeleteItem(lboxIngredients.SelectedIndex);
            if (ok)
            {
                //updates the listbox and labels
                UpdateGUI();
            }
            else
                MessageBox.Show("No item deleted, please select an item", "Error");
        }



        private void btnEditIngredient_Click(object sender, EventArgs e)
        {
            //gets the text from textbox, trimmed.
            string ingredient = txtIngredient.Text.Trim();
            //calls the EditIngredient() method, with currently selected index and current text as arguments
            bool ok = recipe.EditIngredient(lboxIngredients.SelectedIndex, ingredient);
            if (ok)
            {
                //makes sure that the listbox is up to date, must be done after every change
                UpdateGUI();
            }
            else
                MessageBox.Show("Please select an item to edit", "Error");
        }

        private void lboxIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {
            //sets the text of the textbox to the currently selected item in the listbox
            txtIngredient.Text = recipe.GetItemAt(lboxIngredients.SelectedIndex);
        }

        private void FormIngredients_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ok)
            {
                if (recipe.NumOfElements <= 0)//will notify user if no ingredients were added
                {
                    e.Cancel = true;
                    MessageBox.Show("No indgredients added", "Error");
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ok = true;
        }
    }
}
