using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalvinFoodWars
{
    public class Merchandise:Items
    {
        #region Data Members
        private int stock;
        #endregion

        #region Constructors
        public Merchandise(string name, Image picture, int price) : base(name, picture, price)
        {
            Stock = 5;
        }
        #endregion
        #region Properties
        public int Stock
        {
            get => stock;
            private set
            {
                if (value < 0)
                {
                    throw new Exception("Sorry, stock for this merchant is empty.");
                }
                else
                {
                    stock = value;
                }
            }
        }
        #endregion

        #region Methods
        public override string Display()
        {
            string data = "Merchandise\n" + base.DisplayItems() + "\n";
            return data; ;
        }
        public void Sell()
        {
            Stock--;
        }
        public void ResetStock()
        {
            Stock = 5;
        }
        #endregion
    }
}
