using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalvinFoodWars
{
    public class Ingredients
    {
        #region Data Members
        private string name;
        private Image picture; //Image system.Drawing
        #endregion
        #region Constructors
        public Ingredients(string name, Image picture)
        {
            this.Name = name;
            this.Picture = picture;
        }
        #endregion
        #region Properties
        public string Name
        {
            get => name;
            set
            {
                name = value;
            }
        }
        public Image Picture { get => picture; set => picture = value; }
        #endregion
        #region Methods
        public string Display()
        {
            return Name;
        }
        #endregion
    }
}
