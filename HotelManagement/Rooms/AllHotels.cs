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

    }
}
