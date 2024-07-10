using System;
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
        #endregion

        #region Constructors
        public Players(string name, int income, Image picture, Time time)
        {
            this.Name = name;
            this.Income = income;
            this.Picture = picture;
            this.Time = time;
        }

        #endregion

        #region Properties
        public string Name { get => name; set => name = value; }
        public int Income { 
            get => income;
            set
            {
                if (value >= 0) 
                {
                    income = value;
                }
                else
                {
                    throw new Exception("Insufficient money to buy this item");
                }
            }
        }
        public Image Picture { get => picture; set => picture = value; }
        public Time Time { get => time; set => time = value; }
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
        

        #endregion

    }
}
