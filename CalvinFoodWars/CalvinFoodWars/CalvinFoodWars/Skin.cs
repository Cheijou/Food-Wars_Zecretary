using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CalvinFoodWars
{
    public class Skin : Items
    {
        private bool purchased;

        public bool Purchased { get => purchased; set => purchased = value; }

        public Skin(string name, int price, Image picture) : base(name,picture,price)
        {
            Purchased = false;
        }
        public override int Sell(int income)
        {
            if (Name == "merchZeta")
            {
                Purchased = true;
                income -= Price;
            }
            else if (Name == "tumblerZeta")
            {
                Purchased = true;
                income -= Price;
            }
            return income;
        }
        public override string Display()
        {
            return "";
        }
    }
}