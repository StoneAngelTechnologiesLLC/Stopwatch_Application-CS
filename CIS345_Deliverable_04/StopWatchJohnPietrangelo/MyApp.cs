//John Pietrangelo CIS345 Tues/Thurs 9am
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatchJohnPietrangelo
{
    public partial class MyApp : Form
    {
       
        int tenths = 0;
        int seconds = 0;
        int minutes = 0; 
        bool running = false;
        bool firstRun = true;
        bool correctFormat = false;
        int resetMinute;
        int resetSecond;



        public MyApp()
        {
            InitializeComponent();
        }

        private void MyApp_Load(object sender, EventArgs e)
        {
           
            
            stopWatchTmr.Interval = 100;
            stopWatchTmr.Stop();
            dateTimeTmr.Start();
            StopWatch aSUstopWatch = new StopWatch();
        }


        private void startBtn_Click(object sender, EventArgs e)
        {

            if (correctFormat == false )
            {
                try
                {
                    tenths = Convert.ToInt32(tenthsTxBx.Text);
                    seconds = Convert.ToInt32(secondsTxBx.Text);
                    minutes = Convert.ToInt32(minutesTxBx.Text);
                    resetSecond = Convert.ToInt32(secondsTxBx.Text);
                    resetMinute = Convert.ToInt32(minutesTxBx.Text);
                    correctFormat = true;
                    if (minutes < 0 || minutes > 59 || seconds < 0 || seconds > 59)
                    {
                        correctFormat = false;
                        MessageBox.Show(" Error!!! Both Seconds and Minutes Must be within range.\n\nPlease re-enter a integer.  A number between 1 and 59");
                        minutesTxBx.Text = "00";
                        secondsTxBx.Text = "00";
                        tenthsTxBx.Text = "0";
                    }
                }
                catch (FormatException error)
                {
                    MessageBox.Show(error.Message + " Please re-enter a integer.\n\n\t\tA number between 1 and 59");
                    minutesTxBx.Text = "00";
                    secondsTxBx.Text = "00";
                    tenthsTxBx.Text = "0";
                }
            }

            if (firstRun == true && correctFormat == true)
            {
                StopWatch aSUstopWatch = new StopWatch(minutes, seconds, tenths);
                firstRun = false;
                aSUstopWatch.CountDown();
            }
                if (running == false && correctFormat == true)
                {
                    stopWatchTmr.Start();
                    startBtn.Text = "STOP";
                    running = true;
                    minutesTxBx.ReadOnly = true;
                    secondsTxBx.ReadOnly = true;

                    resetBtn.Hide();

                }
                else
                {
                    stopWatchTmr.Stop();
                    running = false;
                    startBtn.Text = "START";
                    resetBtn.Show();
                }
              
        }

        private void resetBtn_Click(object sender, EventArgs e)

        {
            stopWatchTmr.Stop();
           
            StopWatch.Reset();
            
            startBtn.Text = "START";
            running = false;
            minutesTxBx.ReadOnly = false;
            secondsTxBx.ReadOnly = false;
            if (minutes > 0 && minutes < 59 || seconds > 0 && seconds < 59)
            {
                minutes = resetMinute;
                seconds = resetSecond;
                minutesTxBx.Text = resetMinute.ToString();
                secondsTxBx.Text = resetSecond.ToString();
            }
            else
            {
                minutes = 0;
                seconds = 0;
                minutesTxBx.Text = "00";
                secondsTxBx.Text = "00"; ;
            }
            tenthsTxBx.Text = "0";
           
            firstRun = true;
            correctFormat = false;
        }
        private void StopWatch_Tick(object sender, EventArgs e)
        {


            if (tenths == 0 && seconds >= 1)
            {
                seconds--;
                tenths = 10;
                tenths--;
            }
            else if (tenths == 0 && seconds == 0 && minutes >= 1)
            {
                minutes--;
                seconds =59;
                tenths = 10;
                tenths--;
            }
            else if(minutes == 0 && seconds == 0 && tenths == 0)
            {
                stopWatchTmr.Stop();
                startBtn.Text = "START";
            }
            else
            {
                tenths--;
            }
            tenthsTxBx.Text = Convert.ToString(tenths);
            secondsTxBx.Text = Convert.ToString(seconds);
            minutesTxBx.Text = Convert.ToString(minutes);
        }

        private void DateTimer_Tick(object sender, EventArgs e)
        {
            DateTime timeNow = DateTime.Now;
            dateTimeLbl.Text = Convert.ToString(timeNow);

        }

    }
}
