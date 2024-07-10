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
        public Buff(string name, int price, Image picture, Players players) : base(name, price, picture, players)
        {

        }

        public override void Sell(string temp)
        {
            if (temp == "boost")
            {
                foreach(ItemsShop s in Player.ListItem)
                {
                    if (s is Buff a)
                    {
                        if(a.Name == "boost")
                        {
                            a.Stock++;
                            Player.Income -= a.Price;
                        }
                    }                    
                }
            }
            else if (temp == "freeze")
            {
                foreach (ItemsShop s in Player.ListItem)
                {
                    if (s is Buff a)
                    {
                        if (a.Name == "freeze")
                        {
                            a.Stock++;
                            Player.Income -= a.Price;
                        }
                    }
                }
            }
        }
        public override string Display(string temp)
        {
            if (temp == "boost")
            {
                return base.DisplayItems() + "\n" + "Boost 2x order value for 10 seconds";
            }
            else
            {
                return base.DisplayItems() + "\n" + "Freeze the times for 10 seconds";
            }
        }
    }
}