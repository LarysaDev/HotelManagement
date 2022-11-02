using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Exceptions
{
    public class NoCheckedOptionException : Exception
    {
        public NoCheckedOptionException() : base() { }
        public NoCheckedOptionException(string input) : base(String.Format("Ви не обрали опцію: {0} ", input)) { }
        public NoCheckedOptionException(string input, Exception innerException) : base(input, innerException) { }

        private string strInput;
        public string ExtraErrorInfo
        {
            get { return strInput; }

            set { strInput = value; }
        }
    }
}
