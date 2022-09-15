using HotelManagement.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Reservation
{
    public class Reservation
    {
        protected Customer customer;
        protected DateTime date;
        protected int numberOfRoom;

        public Reservation() { }
    }
}
