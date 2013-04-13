using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Early_Bird_Helper
{
    class Clock
    {
        private int p_hour;
        private int p_minute;

        public Clock(int hour, int minute)
        {
            p_hour = hour;
            p_minute = minute;
            
        }
        public Clock(string hour, string minute) 
        {
            p_hour = Int16.Parse(hour);
            p_minute = Int16.Parse(minute);
        }
        public void subMinutes(int minutes)
        {
            p_minute = p_minute - minutes;
            update();
        }
        
        public String print12() {
            if (p_hour < 12)
                return (string)(p_hour + ":" + String.Format("{0:D2}",p_minute) + " AM");
            if (p_hour > 12)
                return (string)((p_hour - 12) + ":" + String.Format("{0:D2}",p_minute) + " PM");
            else
                return "AN ERROR OCCURED IN Clock.print12()\n";
        }
        public String print24() 
        { 
            return (string)(p_hour + ":" + String.Format("{0:D2}",p_minute));
        }
        
        private void update() 
        {
            while ((p_minute < 0) | (p_minute > 59))
            {

                if (p_minute < 0)
                {
                    p_minute = p_minute + 60;
                    p_hour--;
                }

                if (p_minute > 59)
                {
                    p_minute = p_minute - 60;
                    p_hour++;
                }
            }
            while ((p_hour < 0) | (p_hour > 23))
            {
                if(p_hour<0)
                    p_hour = p_hour +24;
                if (p_hour > 23)
                    p_hour = p_hour - 24;
            }
        }
    }
}
