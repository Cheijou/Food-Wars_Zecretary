using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CalvinFoodWars
{
    public class Skin : Items
    { 
        public Skin(string name, int price, Image picture) : base(name,picture,price)
        {

        }
        public override int Sell(int income)
        {
            return 0;
        }
        public override string Display()
        {
            return "";
        }
    }
}