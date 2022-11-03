using HotelManagement.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Rooms
{
   public abstract class RoomTemplate
    {
        protected  bool isReserved = false;
        protected int numberOfRoom;
        protected int bedsAmount = 1;
        protected int roomsAmount = 1;
        protected int windows = 1;
        protected double square;
        protected bool hasAppliances = false;
        protected double price;
        protected List<DateTime> reservedDates = new List<DateTime>();
        protected bool hasBreakfast = false;
        protected bool hasBathroom = false;
        protected bool dailyCleaning = false;
        protected bool hasOwnBathroom = false;
        public RoomTemplate() { }

        public RoomTemplate(
            int numberOfRoom,
            int rooms,
            int beds,
            int windows,
            double square,
            double price
            )
        {
            this.numberOfRoom = numberOfRoom;
            roomsAmount = rooms;
            bedsAmount = beds;
            this.windows = windows;
            this.square = square;
            this.price = price;
        }

        public abstract void setRequirements(int stars);
        public abstract String getDescription(int stars);
        public int getWindows() { return windows; }
        public double getSquare() { return square; }
        public int getRoomsAmount() { return roomsAmount; }
        public int getBeds() { return bedsAmount; }
        public bool hasHouseholdAppliances() { return hasAppliances; }
        public double getPrice() { return price; }
        public List<DateTime> bookedDates() { return reservedDates; }
        public void reserveRoom(DateTime from, DateTime dateTo)
        {
            for (var day = from.Date; day.Date <= dateTo.Date; day = day.AddDays(1))
                reservedDates.Add(day);
        }
        public bool checkIfReserved(DateTime from, DateTime dateTo)
        {
            int index = 0;
            bool status = false;
            List<DateTime> newList = new List<DateTime>();
            for (var day = from.Date; day.Date <= dateTo.Date; day = day.AddDays(1))
            {
                newList.Add(day);
            }
            foreach (var day in newList)
            {
                if (this.bookedDates().Contains(day)) { status = true; break; }
            }
            return status;
        }
        public List<DateTime> getBookedDays()
        {
            return reservedDates;
        }
        public void setReserved(Customer customer, DateTime dateFrom, DateTime dateTo)
        {
            reserveRoom(dateFrom, dateTo);

        }
        public String getAppliances()
        {
            return "Фен та міні косметика";
        }
   
        public int getNumber()
        {
            return this.numberOfRoom;
        }

        public bool isAffordable(double priceFrom, double priceTo)
        {
            return (this.price >= priceFrom && this.price <= priceTo);
        }
        public bool isReservedRoom()
        {
            return isReserved;
        }
    }
}
