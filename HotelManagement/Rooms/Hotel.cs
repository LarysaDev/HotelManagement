using HotelManagement.Customers;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Rooms
{
    public class Hotel
    {
        public string name { get; set; }
        public int starsAmount { get; set; }
        protected List<StandartRoom> standartRooms = new List<StandartRoom>(50);
        protected List<LuxRoom> luxRooms = new List<LuxRoom>(50);

        protected int peopleLivingInStandart = 0;
        protected int peopleLivingInLux = 0;
        public Hotel()
        {
           
        }
        public void setName(String name) { this.name = name; }
        public void setStars(int stars) { this.starsAmount = stars; }
        public String getName() { return this.name; }
        public Hotel(string name, int starsAmount)
        {
            this.name = name;
            this.starsAmount = starsAmount;
        }
        public void addRooms(List<StandartRoom> rooms) 
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
        public void addLuxRooms(List<LuxRoom> rooms)
        {
            this.luxRooms = rooms;
        }
        public void addLuxRoom(LuxRoom room)
        {
            luxRooms.Add(room);
        }
        public List<StandartRoom> getStandartRooms()
        {
            return standartRooms;

        }
        public List<LuxRoom> getLuxRooms()
        {
            return luxRooms;
        }
        public int getStars() { return starsAmount; }
        public StandartRoom getBestStandartRoom() {
            List<StandartRoom> list = new List<StandartRoom>(20);
            StandartRoom bestRoom = new StandartRoom();
            int bookings = 0;
            foreach (var room in this.getStandartRooms())
            {
                if(room.getBookedDays().Count > bookings) {
                    bookings = room.getBookedDays().Count;
                    bestRoom = room;
                }
            }
            return bestRoom;
        }
        public LuxRoom getBestLuxRoom()
        {
            List<LuxRoom> list = new List<LuxRoom>();
            LuxRoom bestRoom = new LuxRoom();
            int bookings = 0;
            foreach (var room in this.getLuxRooms())
            {
                if (room.getBookedDays().Count > bookings)
                {
                    bookings = room.getBookedDays().Count;
                    bestRoom = room;
                }
            }
            return bestRoom;
        }
        public List<StandartRoom> standartProposition() {
            List<StandartRoom> list = new List<StandartRoom>();
            StandartRoom bestRoom = new StandartRoom();
            foreach (var room in this.getStandartRooms())
            {
                if (room.getBookedDays().Count > 0)
                {
                    list.Add(room);
                }
            }
            return list;
        }
        public List<LuxRoom> luxProposition()
        {
            List<LuxRoom> list = new List<LuxRoom>();
            StandartRoom bestRoom = new StandartRoom();
            foreach (var room in this.getLuxRooms())
            {
                if (room.getBookedDays().Count > 0)
                {
                    list.Add(room);
                }
            }
            return list;
        }
    }
}
