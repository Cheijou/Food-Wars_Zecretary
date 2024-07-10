using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalvinFoodWars
{
    [Serializable]
    public class Time
    {
        #region Data Members
        private int hour;
        private int minute;
        private int second;


        #endregion
        #region Constructors
        public Time()
        {
            this.Hour = 0;
            this.Minute = 0;
            this.Second = 0;
        }
        public Time(int hour, int minute, int second)
        {
            this.Hour = hour;
            this.Minute = minute;
            this.Second = second;
        }
        #endregion

        #region Properties
        public int Hour
        {
            get => hour;
            set
            {
                if (value >= 0 && value <= 23)
                {
                    hour = value;
                }
                else
                {
                    throw (new ArgumentException("Please enter the number in range correctly!"));
                }
            }
        }
        public int Minute
        {
            get => minute;
            set
            {
                if (value >= 0 && value <= 59)
                {
                    minute = value;
                }
                else
                {
                    hour += 1;
                    minute = 0;
                }
            }
        }
        public int Second
        {
            get => second;
            set
            {
                if (value >= 0 && value <= 59)
                {
                    second = value;
                }
                else
                {
                    minute += 1;
                    second = 0;
                }
            }
        }
        #endregion
        #region Methods
        public int Convert()
        {
            int totalTime = (Hour * 3600) + (Minute * 60) + Second;
            return totalTime;
        }
        public void Add(int seconds)
        {  
                int addHour = seconds / 3600;
                int addMinute = (seconds % 3600) / 60;
                int addSeconds = (seconds % 3600) % 60;
                Hour += addHour;
                Minute += addMinute;
                Second += addSeconds;
            #endregion
        }
        public string Display()
        {
            return Hour.ToString().PadLeft(2,'0') + ":" + Minute.ToString().PadLeft(2, '0') + ":" + Second.ToString().PadLeft(2, '0');
        }
    }
}
