//John Pietrangelo CIS345 Tues/Thurs 9am
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatchJohnPietrangelo
{
    class InvalidTimeException:FormatException
    {
        private static string msg = "";
        public InvalidTimeException(string msg) : base(msg)
        {

        }
        
    }
}
