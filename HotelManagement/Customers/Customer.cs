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
        private int age;
        private String firstName;
        private String lastName;
        private String email;
        private String phone;
        private List<int> reservedStandartRooms = new List<int>();
        private List<int> reservedLuxRooms = new List<int>();
        private List<int> daysOfLiving = new List<int>();
        public Customer() { }

        public Customer(
            String firstName, String lastName, String email, String phone, int age)
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
        public void reserveLuxRoom(LuxRoom room, DateTime dayFrom, DateTime dateTo)
        {
            reservedLuxRooms.Add(room.getNumber());
            room.setReserved(this, dayFrom, dateTo);
            int daysOfLiving = 0;
            for (var day = dayFrom.Date; day.Date <= dateTo.Date; day = day.AddDays(1))
                daysOfLiving++;
            this.daysOfLiving.Add(daysOfLiving);
        }
        public List<int> getDaysOfLiving()
        {
            return daysOfLiving;
        }
        public List<int> getBookedStandartRooms()
        {
            return reservedStandartRooms;
        }
        public List<int> getBookedLuxRooms()
        {
            return reservedLuxRooms;
        }

        public string getName() { return this.firstName; }
        public string getlastname() { return this.lastName; }
        public int getAge() { return this.age; }
        public string getPhone() { return this.phone; }
        public string getEmail() { return this.email; }
        public int getLastBookedRoom()
        {
            int lastBooked = 0;
            if (this.getBookedStandartRooms().Count != 0)
            {
                lastBooked = this.getBookedStandartRooms()[this.getBookedStandartRooms().Count - 1];
            }
            else if (this.getBookedLuxRooms().Count != 0)
            {
                lastBooked = this.getBookedLuxRooms()[this.getBookedLuxRooms().Count - 1];
            }
            return lastBooked;
        }
        public String getListOfReservedRooms()
        {
            String rooms = "";
            if (this.getBookedStandartRooms().Count != 0)
            {
                foreach (var room in this.getBookedStandartRooms())
                    rooms += room + ", ";
            }
            else if (this.getBookedLuxRooms().Count != 0)
            {
                foreach (var room in this.getBookedLuxRooms())
                    rooms += room + ", ";
            }
            return rooms;
        }
        public int getMaxDaysOfLiving()
        {
            int maxDays = 0;
            if (this.daysOfLiving.Count != 0)
            {
                foreach(var days in this.daysOfLiving)
                {
                    if(days > maxDays)maxDays = days;
                }
            }
            return maxDays;
        }
        public int getReservationsCount()
        {
            int count = daysOfLiving.Count;
            return count;
        }
    }
    
}
