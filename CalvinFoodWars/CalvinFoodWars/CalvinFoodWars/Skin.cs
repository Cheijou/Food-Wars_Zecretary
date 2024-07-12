using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CalvinFoodWars
{
    [Serializable]
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
                if (income > Price)
                {
                    Purchased = true;
                }
                income -= Price;
            }
            else if (Name == "tumblerZeta")
            {
                if (income > Price)
                {
                    Purchased = true;
                }
                income -= Price;
            }
            return income;
        }
        public override string Display()
        {
            if (Name == "merchZeta")
            {
                return "Vestia Zeta Figure \nexclusive  HoloID Gen 3 Edition.";
            }
            else
            {
                return "Vestia Zeta Tumbler \nexclusive  HoloID Gen 3 Edition.";
            }
        }
    }
}