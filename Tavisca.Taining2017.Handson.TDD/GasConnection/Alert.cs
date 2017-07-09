using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasConnection
{
    class Alert
    {
        public string Message(bool message)
        {
            return message?"Success":"Failed";
        }
    }
}
