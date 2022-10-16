using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;


namespace HotelManagement.Rooms
{

   
    public class Singleton_AllHotels
    {
        protected List<Hotel> hotels;

        private static Singleton_AllHotels Instance = new Singleton_AllHotels(20);
        private Singleton_AllHotels(int hotelsAmount) {
            hotels = new List<Hotel>(hotelsAmount);
        }

        public static Singleton_AllHotels AllHotels
        {
            get{ return Instance; }
        }
    
        public List<Hotel> getListOfHotels()
        {
            return hotels;
        }
        public void addHotel(Hotel hotel)
        {
            hotels.Add(hotel);
        }
        public void addHotels(List<Hotel> hotelSet)
        {
            hotels = hotelSet;
        }
        public List<Hotel> getFiltratedHotels(int stars)
        {
            List<Hotel> new_hotels;
            if(stars == 0) { return hotels; }
            else
            {
                new_hotels = new List<Hotel>();
               foreach(var hotel in this.hotels)
                {
                    if(hotel.starsAmount == stars)
                    {
                        new_hotels.Add(hotel);
                    }
                }
                return new_hotels;
            }

        }
       public StandartRoom getBestStRoom()
        {
            List<StandartRoom> list = new List<StandartRoom>();
            StandartRoom bestRoom = new StandartRoom();
            foreach (var hotel in AllHotels.getListOfHotels())
            {
                list.Add(hotel.getBestStandartRoom());
            }
            bestRoom = list[0];
            foreach(var room in list)
            {
                if(room.getBookedDays().Count > bestRoom.getBookedDays().Count)
                {
                    bestRoom = room;
                }
            }
            return bestRoom;
           
        }
        public LuxRoom getBestLuxRoom()
        {
            List<LuxRoom> list = new List<LuxRoom>();
            LuxRoom bestRoom = new LuxRoom();
             foreach (var hotel in AllHotels.getListOfHotels())
            {
                list.Add(hotel.getBestLuxRoom());
            }
            bestRoom = list[0];
            foreach (var room in list)
            {
                if (room.getBookedDays().Count > bestRoom.getBookedDays().Count)
                {
                    bestRoom = room;
                }
            }
            return bestRoom;
       
        }
        public List<StandartRoom> getStandartProposition() {
            List<StandartRoom> list = new List<StandartRoom>();
            foreach (var hotel in AllHotels.getListOfHotels())
            {
                List<StandartRoom> list2 = new List<StandartRoom>();
                list2 = hotel.standartProposition();
                foreach(var room in list2)
                {
                    list.Add(room);
                }
            }
            return list;
        }
        public List<LuxRoom> getLuxProposition()
        {
            List<LuxRoom> list = new List<LuxRoom>();
            foreach (var hotel in AllHotels.getListOfHotels())
            {
                List<LuxRoom> list2 = new List<LuxRoom>();
                list2 = hotel.luxProposition();
                foreach (var room in list2)
                {
                    list.Add(room);
                }
            }
            return list;
        }

    }
}
