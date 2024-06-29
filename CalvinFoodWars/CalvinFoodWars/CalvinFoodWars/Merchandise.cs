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
        private int stockPlushie;
        private int stockTumbler;
        #endregion

        #region Constructors
        public Merchandise(string name, Image picture, int price) : base(name, picture, price)
        {
            StockPlushie = 5;
            StockTumbler = 5;
        }
        #endregion
        #region Properties
        public int StockPlushie
        { 
            get => stockPlushie;
            private set
            {
                if (value < 0)
                {
                    throw new Exception("Sorry, stock for this merchant is empty.");
                }
                else
                {
                    stockPlushie = value;
                }
            }
        }
        public int StockTumbler 
        {
            get => stockTumbler;
            private set
            {
                if (value < 0)
                {
                    throw new Exception("Sorry, stock for this merchant is empty.");
                }
                else
                {
                    stockTumbler = value;   
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
            if (Name == "plushie")
            {
                StockPlushie--;
            }
           
            if (Name == "tumbler")
            {
                StockTumbler--;
            }
        }
        public void ResetStock()
        {
            StockPlushie = 5;
            StockTumbler = 5;
        }
        #endregion
    }
}
