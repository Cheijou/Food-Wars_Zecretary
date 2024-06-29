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
        private Players player;

        protected ItemsShop(string name, int price, Image picture, Players player)
        {
            this.Name = name;
            this.Price = price;
            this.Picture = picture;
            this.Player = player;
        }

        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public Image Picture { get => picture; set => picture = value; }
        public Players Player { get => player; set => player = value; }

        public abstract void Sell(string temp);
        public abstract string Display(string temp);
        protected string DisplayItems()
        {
            return "Name: " + Name +
                   "\nPrice: " + Price;
        }
        
    }
}