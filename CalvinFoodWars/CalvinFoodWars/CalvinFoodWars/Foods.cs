using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalvinFoodWars
{
    public class Foods:Items
    {
        #region Data Members
        //tidak ada data member khusus

        //mengambil data member dari composition Ingredients
        List<Ingredients> listIngredients;

        public Foods(string name, Image picture, int price) : base(name, picture, price)
        {
            ListIngredients = new List<Ingredients>(); //list composition
        }
        #endregion

        #region Constructors

        #endregion

        #region Properties
        public List<Ingredients> ListIngredients { get => listIngredients; private set => listIngredients = value; }
        #endregion

        #region Methods
        public void AddIngredients(string name, Image picture)
        {
            Ingredients ingredients = new Ingredients(name, picture);
            ListIngredients.Add(ingredients);
        }
        public override string Display()
        {
            string data = "Food\n"+base.DisplayItems()+"\nIngredients";
            
            foreach(Ingredients ingredient in listIngredients)
            {
                data+=ingredient.Display()+"\n";
            }
            return data;
        }
        #endregion
    }
}
