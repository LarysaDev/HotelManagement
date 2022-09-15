using HotelManagement.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Customers
{
    public class Customer
    {
        protected int age;
        protected String firstName;
        protected String lastName;
        protected String email;
        protected String phone;
        protected List<int> reservedStandartRooms;
        protected List<int> reservedLuxRooms;
        protected List<int> daysOfLiving;
        public Customer() { }

        public Customer(
            int age, String firstName, String lastName, String email, String phone)
        {
            this.age = age;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.phone = phone;
        }
        public void reserveStandartRoom(StandartRoom room, DateTime dayFrom, DateTime dateTo)
        {
            reservedStandartRooms.Add(room.getNumber());
            room.setReserved(this, dayFrom, dateTo);
            int daysOfLiving = 0;
            for (var day = dayFrom.Date; day.Date <= dateTo.Date; day = day.AddDays(1))
                daysOfLiving++;
            this.daysOfLiving.Add(daysOfLiving);
        }
        public void reserveLuxtRoom(int room, int daysOfLiving)
        {
            reservedLuxRooms.Add(room);
            this.daysOfLiving.Add(daysOfLiving);
        }
    }
}
