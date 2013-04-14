using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Early_Bird_Helper
{
    public partial class Form1 : Form
    {
        string[] hours, minutes, results;
        Clock clock;
        int interval;
        int showCycles;
        DateTime now;
        public Form1()
        {
            showCycles = 4;
            interval = 90;
            results = new string[5];

            hours = new string[] {  "0" , "1" , "2" , "3" , "4" ,
                                    "5" , "6" , "7" , "8" , "9" ,
                                    "10" , "11" , "12" , "13" ,
                                    "14" , "15" , "16" , "17" ,
                                    "18" , "17" , "18" , "19" ,
                                    "20" , "21" , "22" , "23" };

            minutes = new string[] { "00", "15", "30", "45" };
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            // Look at this use of the foreach/in to add the items individual strings into the combonation box
            foreach (string s in hours)
                hourBox.Items.Add(s);

            foreach (string s in minutes)
                minuteBox.Items.Add(s);
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            cycleList.Items.Clear();
            if ((!wakeRadio.Checked) && (!sleepRadio.Checked))
                return;
           
            if (wakeRadio.Checked)
            {
                Console.WriteLine("wakeup time has been given, calculating optimal sleep times");
                clock = new Clock(hourBox.SelectedItem.ToString(), minuteBox.SelectedItem.ToString());
                Console.WriteLine(clock.print24());
                int i = 1;
                clock.subMinutes(14);
                clock.subMinutes(180);

                while (i <= showCycles)
                {
                    clock.subMinutes(interval);
                    results[i] = clock.print24();
                    Console.WriteLine(results[i]);
                    i++;
                }
                foreach (string s in results)
                    cycleList.Items.Add(s);

            }
            if (sleepRadio.Checked)
            {
                Console.WriteLine("User is going to sleep right now, calculating optimal wakeup times");
                now = new DateTime();
                now = System.DateTime.Now;
                clock = new Clock(now.Hour, now.Minute);
                Console.WriteLine(clock.ToString());
                int i = 1;
                clock.addMinutes(14);
                clock.addMinutes(180);

                while (i <= showCycles)
                {
                    clock.addMinutes(interval);
                    results[i] = clock.print24();
                    Console.WriteLine(results[i]);
                    i++;
                }
                foreach (string s in results)
                    cycleList.Items.Add(s);
            }
            
        }

        
    }
}
