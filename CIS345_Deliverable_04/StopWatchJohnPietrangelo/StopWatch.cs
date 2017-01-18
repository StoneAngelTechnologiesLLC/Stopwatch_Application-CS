//John Pietrangelo CIS345 Tues/Thurs 9am
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatchJohnPietrangelo
{
    class StopWatch
    {
        private int minute;
        private int second;
        private int tenthS;
        public int resetMinute;
        public int resetSecond;

        public int Minute
        {
            get
            {
                return minute;
            }
            set
            {
                if (value < 60 && value > 0)
                {
                    minute = value;
                }

            }
        }

        public int Second
        {
            get
            {
                return second;
            }
            set
            {
                if (value < 60 && value > 0)
                {
                    second = value;
                }

            }
        }
        public int TenthS
        {
            get
            {
                return tenthS;
            }
            set
            {
                tenthS = 0;
            }
        }

        public int ResetMinute
        {
            get
            {
                return resetMinute;
            }
            set
            {

            }
        }
        public int ResetSecond
        {
            get
            {
                return resetSecond;
            }
            set
            {

            }
        }

        public StopWatch()
        {
            minute = 0;
            second = 0;
            tenthS = 0;
        }

        public StopWatch(int min, int sec, int tenth)
        {
            minute = min;
            second = sec;
            tenthS = tenth;
            resetMinute = min;
            resetSecond = sec;
        }

        public string CountDown()
        {
            return "";
        }
        public static string Reset()
        {
            return "";
        }

    }
}
