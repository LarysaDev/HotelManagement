using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace HotelManagement.Rooms
{

   
    public class Singleton_AllHotels
    {
        protected HashSet<Hotel> hotels;

        private static Singleton_AllHotels Instance = new Singleton_AllHotels(20);
        private Singleton_AllHotels(int hotelsAmount) {
            hotels = new HashSet<Hotel>(hotelsAmount);
        }

        public static Singleton_AllHotels AllHotels
        {
            get{ return Instance; }
        }
    
        public HashSet<Hotel> getListOfHotels()
        {
            return hotels;
        }
        public void addHotel(Hotel hotel)
        {
            hotels.Add(hotel);
        }
        public void addHotels(HashSet<Hotel> hotelSet)
        {
            hotels = hotelSet;
        }


    }
}
