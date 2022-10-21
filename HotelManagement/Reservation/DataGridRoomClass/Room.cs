using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Reservation.DataGridRoomClass
{
    public class Room
    {
        public String HotelName { get; set; }
        public int Stars { get; set; }
        public int Number { get; set; }
        public int Rooms { get; set; }
        public int Beds { get; set; }
        public int Windows { get; set; }
        public double Square { get; set; }
        public bool Appliances { get; set; }
        public double Price { get; set; }
    }
}
