using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HotelManagement.Exceptions
{
    public class EmptyInputException : Exception
    {
        public EmptyInputException() : base() { }
        public EmptyInputException(string input) : base(String.Format("Ви заповнили не всі поля із заданих: {0}", input)) { }
        public EmptyInputException(string input, Exception innerException) : base(input, innerException) { }
        
        private string strInput;
        public string ExtraErrorInfo
        {
            get
            {
                return strInput;
            }

            set
            {
                strInput = value;
            }
        }

    }
}
