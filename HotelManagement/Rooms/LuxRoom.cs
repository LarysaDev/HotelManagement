using HotelManagement.Customers;
using HotelManagement.Reservation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Rooms
{
    public class  LuxRoom 
    {
        private bool isReserved = false;
        private int numberOfRoom;
        private Customer customer;

        private int bedsAmount = 1;
        private int roomsAmount = 1;
        private int windows = 1;
        private double square;
        private bool hasAppliances = false;
        private double price;
        private List<DateTime> reservedDates = new List<DateTime>();
        private bool hasBreakfast = false;
        private bool hasBathroom = false;
        private bool dailyCleaning = false;
        private bool hasOwnBathroom = false;
        private bool hasBalcony = false;
        private bool hasLivingRoom = false;
        private bool hasBedRoom = false;
        private bool hasSofa = false;
        private bool hasStrongBox = false;

        public LuxRoom() { }

        public LuxRoom(
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
       
        public int getWindows() { return windows; }
        public double getSquare() { return square; }
        public int getRoomsAmount() { return roomsAmount; }
        public int getBeds() { return bedsAmount; }
        public bool hasHouseholdAppliances() { return hasAppliances; }
        public double getPrice() { return price; }
        public List<DateTime> bookedDates() { return reservedDates; }
        virtual public void reserveRoom(DateTime from, DateTime dateTo)
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
        virtual public void setReserved(Customer customer, DateTime dateFrom, DateTime dateTo)
        {
            reserveRoom(dateFrom, dateTo);

        }
        virtual public String getAppliances()
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
        public void  setRequirements (int stars)
        {
            switch (stars)
            {
                case 1:
                    hasOwnBathroom = true;
                    hasSofa = true;
                    hasBreakfast = true;
                    roomsAmount = 2;
                    break;
                case 2:
                    hasOwnBathroom = true;
                    dailyCleaning = true;
                    hasSofa=true;
                    hasBedRoom=true;
                    roomsAmount = 3;
                    break;
                case 3:
                    hasOwnBathroom = true;
                    hasAppliances = true;
                    hasBedRoom = true;  
                    hasBreakfast = true;
                    dailyCleaning = true;
                    hasBalcony = true;
                    hasLivingRoom = true;
                    roomsAmount = 4;
                    break;
                case 4:
                    hasOwnBathroom = true;
                    hasAppliances = true;
                    hasBreakfast = true;
                    dailyCleaning = true;
                    hasBalcony = true;
                    hasLivingRoom = true;
                    hasBedRoom = true;
                    hasStrongBox = true;
                    roomsAmount = 4;
                    break;
                case 5:
                    hasOwnBathroom = true;
                    hasAppliances = true;
                    hasBreakfast = true;
                    dailyCleaning = true;
                    hasBalcony = true;
                    hasLivingRoom = true;
                    hasBedRoom = true;
                    hasStrongBox = true;
                    roomsAmount = 4;
                    break;
                default: break;
            }
        }
    }
}
