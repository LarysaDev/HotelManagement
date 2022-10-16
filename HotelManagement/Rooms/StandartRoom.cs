﻿using HotelManagement.Customers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Rooms
{
    public class StandartRoom
    {
        protected bool isReserved = false;
        protected int numberOfRoom;
        protected Customer customer;

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
        public StandartRoom() { }
       
        public StandartRoom(
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

        virtual public void setRequirements(int stars)
        {
            switch (stars)
            {
                case 1:
                    hasBathroom = true;
                    roomsAmount = 1;
                    break;
                case 2:
                    hasBathroom = true;
                    dailyCleaning = true;
                    roomsAmount = 1;
                    break;
                case 3:
                    hasOwnBathroom = true;
                    hasAppliances = true;
                    hasBreakfast = true;
                    dailyCleaning=true;
                    roomsAmount = 2;
                    break;
                case 4:
                    hasOwnBathroom = true;
                    hasAppliances = true;
                    hasBreakfast = true;
                    dailyCleaning = true;
                    roomsAmount = 2;
                    break;
                case 5:
                    hasOwnBathroom = true;
                    hasAppliances = true;
                    hasBreakfast = true;
                    dailyCleaning = true;
                    roomsAmount = 2;
                    break;
                default: break;
            }
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
            foreach(var day in newList)
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
        virtual public String  getAppliances()
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
