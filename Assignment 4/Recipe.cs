using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{/// <summary>
/// Class for storing information about a recipe, such as name, ingredients and category
/// </summary>
    class Recipe
    {
        private string name;//Stores recipe name
        private string description;//stores instruction and other additional information
        private string[] ingredients;//array of the ingredients needed
        private Categories category;//what category the recipe belongs to
        private int numOfElements = 0;//keeps track of how many elements of ingredients have value

        /// <summary>
        /// Constructor for the class.
        /// </summary>
        /// <param name="maxNumOfIngredients"></param>
        public Recipe(int maxNumOfIngredients)
        {
            //creates and array of ingredients where all values are null
            ingredients = new string[maxNumOfIngredients];
        }
        /// <summary>
        /// Copyconstructor.
        /// </summary>
        /// <param name="other">recipe object to be copied</param>
        public Recipe(Recipe other)
        {
            this.name = other.name;
            this.description = other.description;
            this.category = other.category;
            this.ingredients = other.ingredients;
            this.numOfElements = other.numOfElements;
        }
        #region Properties

        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    name = value;
            }
        }

        public string Description
        {
            get { return description; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    description = value;
            }
        }

        public string[] Ingredients
        {//No set is needed, other methods handles adding and editing elements of the array
            get { return ingredients; }//used to get the strings in ingredients
        }

        public Categories Category
        {
            get { return category; }
            set
            {
                //no validation necessary, can only have valid values
                category = value;
            }
        }

        public int NumOfElements
        {//used to give information on how many ingredients are currently in the recipe
            get { return numOfElements; }
        }
        #endregion

        public bool AddIngredient(string ingredient)
        {//tries to add new indredient to empty element in ingredients array
            bool success = false;//bool to return
            //makes sure that number of elements is less than array lenght, also checks if argument isn't empty
            if(numOfElements < ingredients.Length && !string.IsNullOrEmpty(ingredient))
            {
                ingredients[numOfElements] = ingredient;//adds the ingredient from argument to first index with empty string
                //numOfElements start at 0, meaning first element in array, after 1 is added, it is increased to 1, 2nd element in array
                numOfElements++;//increase number of elements with value
                success = true;//sets return value to true, operation successful
            }

            return success;//true if ingredient added, false if not
        }

        public string GetItemAt(int index)
        {
            string item = "Nothing found";//returned if string was empty
            if(index >= 0)//must not be negative
            {
                if(!string.IsNullOrEmpty(ingredients[index]))
                item = ingredients[index];//gets the string from desired index in the array
            }
            return item;//returns string from desired index, or nothing found if index is empty
        }

        public bool DeleteItem(int index)
        {
            bool success = false;
            if(index >= 0)//negative index, if for some reason sent, will cause exception error
            {
                ingredients[index] = string.Empty;//delete information at index
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
            for(int i = index + 1; i < ingredients.Length; i++)
            {
                ingredients[i - 1] = ingredients[i];//Move information to the left
                ingredients[i] = string.Empty;//emtpies moved element, keeps numOfElements accurate
            }
        }

        public bool EditIngredient(int index, string ingredient)//edit an ingredient in ingredients
        {
            bool success = false;
            //make sure index is valid int and that string has a value
            if(index >= 0 && !string.IsNullOrEmpty(ingredient))
            {
                ingredients[index] = ingredient;//changes element at desired index to argument string
                success = true;//operation successful
            }

            return success;//true if successful, false if not
        }

        public string[] ShowIngredients()
        {
            string[] outputArray = null;
            if(numOfElements > 0)//makes sure there are ingredients added to display
            {
                outputArray = new string[numOfElements];//creates a new array, lenght = numOfElements
            }
            
            for(int i = 0; i < ingredients.Length; i++)
            {
                if (!string.IsNullOrEmpty(ingredients[i]))
                {
                    outputArray[i] = ingredients[i];
                }
            }
            return outputArray;
        }
    }
}
