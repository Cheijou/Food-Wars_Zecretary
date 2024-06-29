using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CalvinFoodWars
{
    public class Skin : ItemsShop
    {
        public Skin(string name, int price, Image picture, Players players) : base(name, price, picture, players)
        {
        }
        public override void Sell(string temp)
        {

        }
        public override string Display(string temp)
        {
            return "";
        }
    }
}