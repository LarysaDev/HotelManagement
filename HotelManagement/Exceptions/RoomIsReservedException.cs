using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Exceptions
{
    public class RoomIsReservedException : Exception
    {
        public RoomIsReservedException() : base() { }
        public RoomIsReservedException(string input) : base(String.Format("Обрана кімната є вже зарезервованою: {0}.", input)) { }
        public RoomIsReservedException(string input, Exception innerException) : base(input, innerException) { }

        private string strInput;
        public string ExtraErrorInfo
        {
            get { return strInput; }

            set { strInput = value; }
        }
    }
}
