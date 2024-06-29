using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalvinFoodWars
{
    public class Items
    {
        #region Data Members
        private string name;
        private Image picture;
        private int price;
        #endregion

        #region Constructors
        protected Items(string name, Image picture, int price)
        {
            this.Name = name;
            this.Picture = picture;
            this.Price = price;
        }
        #endregion

        #region Properties
        public string Name { get => name; set => name = value; }
        public Image Picture { get => picture; set => picture = value; }
        public int Price { get => price; set => price = value; }
        #endregion

        #region Methods
        protected string DisplayItems()
        {
            return "Name: " + Name +
                   "\nPrice: " + Price;
        }
        public virtual string Display()
        {
            return "";
        }
        
        #endregion
    }
}
