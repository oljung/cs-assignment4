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
    public partial class MainForm : Form
    {

        private Recipe currRecipe = new Recipe(maxNumOfIngredients);
        private RecipeManager recipeMngr = new RecipeManager(maxNumOfRecipes);
        private const int maxNumOfIngredients = 50;//number of ingredients per recipe
        private const int maxNumOfRecipes = 200;//max number of recipes
        private int indexToEdit = -1;//used as a security with the edit button, see save button method
        public MainForm()
        {
            InitializeComponent();
            //sets the values of the drop down of the category combobox to the values of
            //the Category enum
            cboxCategory.DataSource = Enum.GetValues(typeof(Categories));
            UpdateGUI();//always called when GUI is loaded of any item has changed in any way
        }

        private void UpdateGUI()
        {
            lboxRecipeList.Items.Clear();//clear listbox of information
            txtNameOfRecipe.Text = string.Empty;//removes any lingering text
            txtDescription.Text = string.Empty;//removes any lingering text
            //creates a new array of strings using the current recipes in recipeList
            string[] recipes = recipeMngr.ShowRecipes();
            if(recipes != null)//will return null if numOfElements == 0
            {
                lboxRecipeList.Items.AddRange(recipes);//if not null the listbox items are set to the array created
            }
            //creates an empty object every time GUI is updated to avoid old data in ingredients to stick
            currRecipe = new Recipe(maxNumOfIngredients);
            indexToEdit = -1;//not valid indexnumber, will result in error message if edit is attempted
            btnSave.Enabled = false;
            btnAddIngredients.Text = "Add Ingredients";                                              
        }



        private bool ReadValues()//read values from textboxes and combobox
        {
            bool nameOk = ReadName();//Reads and adds name if not empty
            bool descriptionOk = ReadDescription();//reads and adds description if not empty
            //This sets the category of the currRecipe to the category selectid in the combobox
            //The function parses the string in the combox to the enumtype with the same as the string value
            //No validation is needed, as strings in the combobox all come from the enum Categories to begin with
            currRecipe.Category = (Categories)Enum.Parse(typeof(Categories), cboxCategory.SelectedItem.ToString());

            return nameOk && descriptionOk;
        }

        private bool ReadName()//read input from name textbox
        {
            string input = txtNameOfRecipe.Text.Trim();//trim any leading or trailing spaces
            bool ok = false;//only ok if textbox has a string with text
            if (!string.IsNullOrEmpty(input))
            {
                currRecipe.Name = input;//if ok add to current recipe
                ok = true;
            }
            else//if empty, prompt user for input
                MessageBox.Show("Please enter a name", "Error");
            return ok;
        }

        private bool ReadDescription()//works just like ReadName()
        {
            string input = txtDescription.Text.Trim();
            bool ok = false;
            if (!string.IsNullOrEmpty(input))
            {
                currRecipe.Description = input;
                ok = true;
            }
            else
                MessageBox.Show("Please enter a description", "Error");
            return ok;
        }

        private void btnAddIngredients_Click(object sender, EventArgs e)
        {
            //creates a new form of FormIngredients with currRecipe passes as reference
            FormIngredients dlg = new FormIngredients(currRecipe);
            //determines the title of the new form
            if(currRecipe.NumOfElements == 0)
            {
                dlg.Text = "Add ingredients";//if no items are in array, text is "add"
            }
            else
            {
                dlg.Text = "Edit ingredients";//if there are items in array, text is "edit"
            }
            //opens FormIngredients as dialog box
            DialogResult dlgResult = dlg.ShowDialog();
            if(dlgResult == DialogResult.OK)//checks if OK button was pressed
            {
                btnAddIngredients.Text = "Edit Ingredients";
            }
        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {

            bool ok = ReadValues();//read input
            if (ok)//all inputs had value
            {
                bool addOk = recipeMngr.AddRecipe(currRecipe);//adds currRecipe to array of recipes, if there are empty elements
                if (addOk)//add successful
                {
                    UpdateGUI();//updates GUI with new recipe
                }
                else//if recipe was not added for some reason, most likely due to amount limit filled
                {
                    MessageBox.Show("Something went wrong, most likely recipelist is full, recipe not added.", "Error");
                }
            }
            //error messages handled in other methods
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lboxRecipeList.ClearSelected();//clears all selections in listbox.
            //if a recipe was selected for editing, this clears that selection, giving a blank object
            //also clears the textboxes of any information given from select button
            UpdateGUI();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            indexToEdit = lboxRecipeList.SelectedIndex;
            //tries to get the recipe at selected index in listbox.
            bool ok = recipeMngr.GetItemAt(lboxRecipeList.SelectedIndex, out Recipe recipeToEdit);
            if (ok)
            {
                //checks to see if currRecipe contains information
                if (recipeToEdit == null)
                {
                    ok = false;
                }
                currRecipe = new Recipe(recipeToEdit);//makes a copy of selcted index to currRecipe
                btnSave.Enabled = true;//makes the save button clickable
                //these lines enters the values of selected index to the combo- and textboxes
                txtDescription.Text = currRecipe.Description;
                txtNameOfRecipe.Text = currRecipe.Name;
                cboxCategory.SelectedItem = currRecipe.Category;
                if(currRecipe.NumOfElements != 0)
                {
                    btnAddIngredients.Text = "Edit Ingredients";
                }


            }
            else
                MessageBox.Show("Please select an item in the list", "Error");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            bool ok = ReadValues();//read and validate inputs
            if (ok)//inputs are fine
            {
                if(lboxRecipeList.SelectedIndex == indexToEdit)
                {//checks of the selected index has changed since clicking "select button"
                    //tries to edit the recipe at selected index, saving a copy of currRecipe to selected index
                    bool editOk = recipeMngr.EditRecipe(lboxRecipeList.SelectedIndex, new Recipe(currRecipe));
                    if (editOk)//valid index and recipe != null
                    {
                        UpdateGUI();//updates GUI with edited recipe
                    }
                    else
                    {
                        MessageBox.Show("Please select the recipe you wish to edit", "Error");
                    }
                }
                else//index was changed, confirmation is needed to make sure correct recipe is edited
                {//saving an edit to a new index other than selected will cause duplicates
                    string message = "Index appears to have been changes after clicking select." +
                        "\nDo you want to proceed?\n(this will overwrite the recipe saved at the new index,)";//Messege go show in box
                    string title = "Confirm Edit";//title of the messagebox
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;//buttons to show, DialogResult linked
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)//if user clicks yes, proceed with edit despite index selection having changed
                    {
                        bool editOk = recipeMngr.EditRecipe(lboxRecipeList.SelectedIndex, new Recipe(currRecipe));
                        if (editOk)//valid index and recipe != null
                        {
                            UpdateGUI();//updates GUI with edited recipe
                        }
                        else
                        {
                            MessageBox.Show("Please select the recipe you wish to edit", "Error");
                        }
                    }
                    else
                        UpdateGUI();//updates GUI, canceling any action done so far
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //all that is needed to cancel an edit is to call UpdateGUI() method as
            //clears all text and creates a new object of recipe, leaving the selected object intact
            UpdateGUI();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool ok = recipeMngr.DeleteItem(lboxRecipeList.SelectedIndex);
            if (ok)//valid index, item deleted
            {
                //update of GIU is needed to give correct representation
                UpdateGUI();
            }
            else
            {
                MessageBox.Show("Please select a recipe to delete", "Error");
            }
        }

        private void lboxRecipeList_DoubleClick(object sender, EventArgs e)
        {
            //prepares a string with full information form recipe
            string outText = recipeMngr.ShowFullRecipe(lboxRecipeList.SelectedIndex);
            MessageBox.Show(outText);//shows recipe information in a messagebox.
        }
    }
}
