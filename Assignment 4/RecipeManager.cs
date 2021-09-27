using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class RecipeManager
    {
        private Recipe[] recipeList;//array of recipes to store and display
        private int numOfElements = 0;//keeps track of how many recipes are stored, that is, have a value != null

        /// <summary>
        /// Construcor of the class, creates an array of recipes where all elements are null
        /// </summary>
        public RecipeManager(int maxNumOfRecipes)
        {
            //creates an array of recipes whit all values null, size determined by argument sent
            recipeList = new Recipe[maxNumOfRecipes];
        }


        public bool GetItemAt(int index, out Recipe item)
        {
            bool success = false;
            item = null;//returned if element is empty
            if (index >= 0)//must not be negative
            {
                if (recipeList[index] != null)//only sets value if not null
                    item = recipeList[index];//gets the Recipe from desired index in the array
                success = true;
            }
            return success;//returns Recipe from desired index, or null if index is empty
        }

        public bool AddRecipe(Recipe recipe)
        {//tries to add new indredient to empty element in ingredients array
            bool success = false;//bool to return
            //makes sure that number of elements is less than array lenght, also checks if argument isn't empty
            if (numOfElements < recipeList.Length && recipe != null)
            {
                recipeList[numOfElements] = recipe;//adds the ingredient from argument to first index with null value
                //numOfElements start at 0, meaning first element in array, after a recipe is added, it is increased to 1, 2nd element in array
                numOfElements++;//increase number of elements with value
                success = true;//sets return value to true, operation successful
            }

            return success;//true if recipe added, false if not
        }

        public bool DeleteItem(int index)
        {
            bool success = false;
            if (index >= 0)//negative index, if for some reason sent, will cause exception error
            {
                recipeList[index] = null;//delete information at index
                numOfElements--;//updates number of elements with value
                MoveElementsToLeft(index);//fill the "gap" made by removing a value
                success = true;//true if successful
            }
            return success;
        }

        private void MoveElementsToLeft(int index)
        {
            /* Starts i at the element after the removed element (index +1)
             * The element to the left of i, is the element that just got deleted, not empty
             * it takes te value of i, the one to the right. After that, the value of i is set to empty
             * the loop then moves on to the next element to the right, example:
             * Delete at index 4, i now becomes index 5 and sets the value of the now emtpy index 4
             * to the value of index 5, when that is done sets 5 to empty. i then becomes index 6, setting value of
             * 5 to 6 and then emtpy 6, and so on.
             */
            for (int i = index + 1; i < recipeList.Length; i++)
            {
                recipeList[i - 1] = recipeList[i];//Move information to the left
                recipeList[i] = null;//emtpies moved element, keeps numOfElements accurate
            }
        }

        public bool EditRecipe(int index, Recipe recipe)//edit a recipe in recipeList
        {
            bool success = false;
            //make sure index is valid int and that recipe has a value != null
            if (index >= 0 && recipe != null)
            {
                recipeList[index] = recipe;//changes element at desired index to argument recipe
                success = true;//operation successful
            }

            return success;//true if successful, false if not
        }

        public string[] ShowRecipes()//method for creating an array with only the elements of ingredients != emtpy/null
        {
            string[] outputArray = null;
            if(numOfElements > 0)//make sure there are recipes saved to display
                outputArray = new string[numOfElements];//creates a new array, lenght = numOfElements
            for(int i = 0; i < recipeList.Length; i++)
            {
                if (recipeList[i] != null)//tests if string has value
                {
                    outputArray[i] = $"{recipeList[i].Name,-25} {recipeList[i].Category,-20} {recipeList[i].NumOfElements,10}";
                }
                else//no need to iterate after first null value, only null to follow
                    break;

            }
            return outputArray;
        }

        public string ShowFullRecipe(int index)
        {
            Recipe recipe = recipeList[index];//gets recipe from argumentindex
            string[] ingredients = recipe.ShowIngredients();//creates array of only non-empty strings
            string ingredientList = "";//string to return
            for(int i = 0; i < ingredients.Length; i++)
            {//loop converts array to single string, each element seperated by , and ends with .
                
                if (i == 0)//if last string in array ends with .
                    ingredientList += $"{ingredients[i]}";
                else
                    ingredientList += $", {ingredients[i]} ";//adds a space and , after every element
            }
            //creates a long string to be displayed for full details on a recipe
            string recipeInfo = $"INGREDIENTS \n...\n{ingredientList}\n\n{recipe.Description}";
            return recipeInfo;

        }
    }
}
