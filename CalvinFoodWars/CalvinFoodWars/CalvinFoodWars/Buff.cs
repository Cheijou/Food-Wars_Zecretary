using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Diagnostics;
using System.Xml.Linq;

namespace CalvinFoodWars
{
    public class Buff : ItemsShop
    {
        public Buff(string name, int price, Image picture) : base(name, price, picture)
        {
            Stock = 0;
        }

        public override void Sell()
        {
            if (Name== "boost")
            {
                Stock++;
            }
            else if (Name == "freeze")
            {
                Stock++;
            }
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
    }
}