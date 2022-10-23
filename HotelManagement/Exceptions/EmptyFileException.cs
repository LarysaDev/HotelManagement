using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Exceptions
{
    public class EmptyFileException : Exception
    {
        public EmptyFileException() : base() { }
        public EmptyFileException(string input) : base(String.Format("Ви обрали пустий файл")) { }
        public EmptyFileException(string input, Exception innerException) : base(input, innerException) { }

        private string strInput;
        public string ExtraErrorInfo
        {
            get { return strInput; }

            set { strInput = value;}
        }

    }
}
