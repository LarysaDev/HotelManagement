using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Exceptions
{
    public class InvalidHotelInfoException : Exception
    {
        public InvalidHotelInfoException() : base() { }
        public InvalidHotelInfoException(string input) : base(String.Format("Information in the file is not correct: {0}", input)) { }
        public InvalidHotelInfoException(string input, Exception innerException) : base(input, innerException) { }

        private string strInput;
        public string ExtraErrorInfo
        {
            get { return strInput; }

            set { strInput = value; }
        }
    }
}
