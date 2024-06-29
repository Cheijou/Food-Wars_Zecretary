using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalvinFoodWars
{
    public class Beverages : Items
    {
        #region Data Members
        private bool isCold;
        private string size;    
        #endregion

        #region Constructors
        public Beverages(string name, Image picture, int price, bool isCold, string size) : base(name, picture, price)
        {
            this.IsCold = isCold;
            this.Size = size;
        }
        #endregion

        #region Properties
        public bool IsCold { get => isCold; set => isCold = value; }
        public string Size { get => size; set => size = value; }
        #endregion

        #region Methods
        public override string Display()
        {
            string data = "Beverages\n"+base.DisplayItems()+"\n";
            if (IsCold == true)
            {
                data += "This beverage is cold\n";
            }
            else
            {
                data += "This beverage is hot\n";
            }
            data += "Size: " + Size;
            return data;
        }
        #endregion
    }
}
