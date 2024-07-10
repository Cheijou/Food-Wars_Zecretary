using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CalvinFoodWars
{
    public abstract class ItemsShop
    {
        private string name;
        private int price;
        private Image picture;
        private int stock;
        protected ItemsShop(string name, int price, Image picture)
        {
            this.Name = name;
            this.Price = price;
            this.Picture = picture;
            Stock++;
        }

        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public Image Picture { get => picture; set => picture = value; }
        public int Stock { get => stock; set => stock = value; }

        public abstract int Sell(int income);
        public abstract string Display();
        protected string DisplayItems()
        {
            return "Name: " + Name +
                   "\nPrice: " + Price;
        }
    }
}