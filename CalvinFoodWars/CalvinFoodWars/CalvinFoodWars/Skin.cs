using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CalvinFoodWars
{
    public class Skin : ItemsShop
    {
        public Skin(string name, int price, Image picture) : base(name, price, picture)
        {
        }
        public override void Sell()
        {

        }
        public override string Display()
        {
            return "";
        }
    }
}