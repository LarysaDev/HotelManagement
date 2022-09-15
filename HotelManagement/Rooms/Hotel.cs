using HotelManagement.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Rooms
{
    public class Hotel
    {
        public string name { get; set; }
        public int starsAmount { get; set; }
        protected HashSet<StandartRoom> standartRooms;
        protected HashSet<LuxRoom> luxRooms;

        protected int peopleLivingInStandart = 0;
        protected int peopleLivingInLux = 0;
        public Hotel()
        {
            standartRooms = new HashSet<StandartRoom>(20);
            luxRooms = new HashSet<LuxRoom>(20);
        }
        public Hotel(string name, int starsAmount)
        {
            this.name = name;
            this.starsAmount = starsAmount;
        }
        public void addRooms(HashSet<StandartRoom> rooms) 
        {
            this.standartRooms = rooms;
        }
        public void addRoom(StandartRoom room)
        {
            standartRooms.Add(room);    
        }
        public void bookStandartRoom(
            StandartRoom room,
            Customer customer, 
            DateTime dateFrom,
            DateTime dateTo)
        {
            room.setReserved(customer, dateFrom, dateTo);
            peopleLivingInStandart++;
        }
        public void bookLuxRoom(
           LuxRoom room,
           Customer customer,
           DateTime dateFrom,
           DateTime dateTo)
        {
            room.setReserved(customer, dateFrom, dateTo);
            peopleLivingInLux++;
        }
        public void addLuxRooms(HashSet<LuxRoom> rooms)
        {
            this.luxRooms = rooms;
        }
        public void addLuxRoom(LuxRoom room)
        {
            luxRooms.Add(room);
        }
        public HashSet<StandartRoom> getStandartRooms()
        {
            return standartRooms;

        }
        public HashSet<LuxRoom> getLuxRooms()
        {
            return luxRooms;
        }
    }
}
