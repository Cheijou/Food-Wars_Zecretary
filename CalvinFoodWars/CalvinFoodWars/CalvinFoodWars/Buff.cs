using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Diagnostics;
using System.Xml.Linq;

namespace CalvinFoodWars
{
    public class Buff : Items
    {
        #region Data Members
        private int stock;
        #endregion
        
        #region Constructors
        public Buff(string name, int price, Image picture) : base(name,picture,price)
        {
            Stock = 0;
        }
        #endregion

        #region Properties
        public int Stock 
        { 
            get => stock;
            set
            {
                if (value >= 0)
                {
                    stock = value;
                }
                else
                {
                    throw new Exception("Stock empty.");
                }
            }

        }
        #endregion

        #region Methods
        public override int Sell(int income)
        {
            if (Name == "boost")
            {
                income -= Price;
                Stock++;
            }
            else if (Name == "freeze")
            {
                income -= Price;
                Stock++;
            }
            return income;
        }
        public override string Display()
        {
            if (Name == "boost")
            {
                return "Boost 2x order \n value for 10 seconds";
            }
            else
            {
                return "Freeze the times \n for 10 seconds";
            }
        }
        #endregion
    }
}