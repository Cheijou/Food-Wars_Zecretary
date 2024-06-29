using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalvinFoodWars
{
    public class Customers
    {
        #region Data Members
        private string name;
        private string type;
        private Image picture;
        //aggregation with Items
        private Items item;
        #endregion

        #region Constructors
        public Customers(string name, string type, Image picture, Items item)
        {
            this.Name = name;
            this.Type = type;
            this.Picture = picture;
            this.Item = item;
        }
        #endregion

        #region Properties
        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public Image Picture { get => picture; set => picture = value; }
        public Items Item { get => item; set => item = value; }
        #endregion

        #region Methods
        public string Display()
        {
            return "Hi my name\n  is " + Name;
        }
        #endregion


    }
}
