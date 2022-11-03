using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Exceptions
{
    public class InvalidDateException : Exception
    {
      
            public InvalidDateException() : base() { }
            public InvalidDateException(string input) : base(String.Format("Ви обрали неправильний діапазон дат: {0}", input)) { }
            public InvalidDateException(string input, Exception innerException) : base(input, innerException) { }

            private string strInput;
            public string ExtraErrorInfo
            {
                get { return strInput; }

                set { strInput = value; }
            }
    }
}
