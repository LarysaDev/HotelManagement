using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Exceptions
{
    public class InvalidInputInfoException : Exception
    {
        public InvalidInputInfoException() : base() { }
        public InvalidInputInfoException(string input) : base(String.Format("Ви ввели неправильні дані: {0} ", input)) { }
        public InvalidInputInfoException(string input, Exception innerException) : base(input, innerException) { }

        private string strInput;
        public string ExtraErrorInfo
        {
            get { return strInput; }

            set { strInput = value; }
        }
    }
}
