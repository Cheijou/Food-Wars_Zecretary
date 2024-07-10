﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalvinFoodWars
{
    public class Players
    {
        #region Data Members
        private string name;
        private int income;
        private Image picture;
        private Time time;
        private List<ItemsShop> listItem;
        #endregion

        #region Constructors
        public Players(string name, int income, Image picture, Time time)
        {
            this.Name = name;
            this.Income = income;
            this.Picture = picture;
            this.Time = time;
            ListItem = new List<ItemsShop>();
            AddItem(this);
        }

        #endregion

        #region Properties
        public string Name { get => name; set => name = value; }
        public int Income { get => income; set => income = value; }
        public Image Picture { get => picture; set => picture = value; }
        public Time Time { get => time; set => time = value; }
        public List<ItemsShop> ListItem { get => listItem; set => listItem = value; }
        #endregion

        #region Methods
        public string DisplayName()
        {
            return "Name: " + Name;    
                   
        }
        public string DisplayIncome()
        {
            return "Current Income: " + Income;
        }
        public string DisplayTime()
        {
            return "Prev Time Completed: \n" + Time.Hour.ToString().PadLeft(2, '0') + ":" + Time.Minute.ToString().PadLeft(2, '0') + ":" + Time.Second.ToString().PadLeft(2, '0');
        }
        public int AddWithPrice(int income, int price)
        {
            return income += price;
        }
        public void AddIncome(int price)
        {
            Income += price;
        }
        public void AddItem(Players player)
        {
            ItemsShop item = new Buff("freeze", 200000,Properties.Resources.freeze, player);
            listItem.Add(item);
            ItemsShop item2 = new Buff("boost", 300000, Properties.Resources.doublemoney, player);
            listItem.Add(item2);
        }

        #endregion

    }
}
