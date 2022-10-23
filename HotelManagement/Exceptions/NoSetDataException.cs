using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Exceptions
{
    public class NoSetDataException : Exception
    {
        public NoSetDataException() : base() { }
        public NoSetDataException(string input) : base(String.Format("Ви не обрали дату", input)) { }
        public NoSetDataException(string input, Exception innerException) : base(input, innerException) { }

        private string strInput;
        public string ExtraErrorInfo
        {
            get { return strInput; }

            set { strInput = value; }
        }
    }
}
