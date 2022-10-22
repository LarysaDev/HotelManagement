using HotelManagement.Reservation.DataGridRoomClass;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Numerics;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
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

        public ObservableCollection<Room> filtrateStandartRooms(
            ObservableCollection<Room> myObjects,
            int userStars,
            DateTime userDateFrom, DateTime userDateTo,
            DatePicker dateFrom, DatePicker dateTo,
            double userPriceFrom, double userPriceTo
            )
        {
            bool isInBudget = true;
            bool isReserved = false;
            foreach (Hotel hotel in this.getFiltratedHotels(userStars))
            {
                List<StandartRoom> stRooms = hotel.getStandartRooms();
                if (stRooms != null)
                    foreach (var room in stRooms)
                    {
                        if (dateFrom != null)
                        {
                            if (dateTo != null)
                            {
                                isReserved = room.checkIfReserved(userDateFrom, userDateTo);
                            }
                            else
                            {
                                isReserved = room.checkIfReserved(userDateFrom, userDateFrom);
                            }
                        }
                        if (isReserved == false)
                        {
                            if (userPriceFrom != 0)
                            {
                                if (userPriceTo != 0)
                                {
                                    isInBudget = room.isAffordable(userPriceFrom, userPriceTo);
                                }
                                else isInBudget = room.isAffordable(userPriceFrom, userPriceFrom + 1);
                            }
                            if (isInBudget)
                            {
                                myObjects.Add(new Room()
                                {
                                    HotelName = hotel.getName(),
                                    Stars = hotel.getStars(),
                                    Number = room.getNumber(),
                                    Rooms = room.getRoomsAmount(),
                                    Beds = room.getBeds(),
                                    Windows = room.getWindows(),
                                    Square = room.getSquare(),
                                    Appliances = room.hasHouseholdAppliances(),
                                    Price = room.getPrice()
                                });
                            }

                        }

                    }
            }

                return myObjects;
        }
        public ObservableCollection<Room> filtrateLuxRooms(
            ObservableCollection<Room> myObjects,
            int userStars,
            DateTime userDateFrom, DateTime userDateTo,
            DatePicker dateFrom, DatePicker dateTo,
            double userPriceFrom, double userPriceTo
            )
        {
            bool isInBudget = true;
            bool isReserved = false;
            foreach (Hotel hotel in this.getFiltratedHotels(userStars))
            {
                List<LuxRoom> luxRooms = hotel.getLuxRooms();
                if (luxRooms != null)
                    foreach (var room in luxRooms)
                    {
                        if (dateFrom != null)
                        {
                            if (dateTo != null)
                            {
                                isReserved = room.checkIfReserved(userDateFrom, userDateTo);
                            }
                            else
                            {
                                isReserved = room.checkIfReserved(userDateFrom, userDateFrom);
                            }
                        }
                        if (isReserved == false)
                        {
                            if (userPriceFrom != 0)
                            {
                                if (userPriceTo != 0)
                                {
                                    isInBudget = room.isAffordable(userPriceFrom, userPriceTo);
                                }
                                else isInBudget = room.isAffordable(userPriceFrom, userPriceFrom + 1);
                            }
                            if (isInBudget)
                            {
                                myObjects.Add(new Room()
                                {
                                    HotelName = hotel.getName(),
                                    Stars = hotel.getStars(),
                                    Number = room.getNumber(),
                                    Rooms = room.getRoomsAmount(),
                                    Beds = room.getBeds(),
                                    Windows = room.getWindows(),
                                    Square = room.getSquare(),
                                    Appliances = room.hasHouseholdAppliances(),
                                    Price = room.getPrice()
                                });
                            }
                        }
                    }
            }
            return myObjects;
        }
        public ObservableCollection<Room> getListOfBestStandartRooms(
              ObservableCollection<Room> myObjects,
            DateTime userDateFrom, DateTime userDateTo,
            DatePicker dateFrom, DatePicker dateTo
            )
        {

            StandartRoom bestStRoom = new StandartRoom();
            bool isReservedStandart = false;

                        bestStRoom = this.getBestStRoom();
            if (dateFrom != null)
            {
                if (dateTo != null)
                {
                    isReservedStandart = bestStRoom.checkIfReserved(userDateFrom, userDateTo);
                }
                else
                {
                    isReservedStandart = bestStRoom.checkIfReserved(userDateFrom, userDateFrom);
                }
            }

            if (isReservedStandart == false && bestStRoom.getNumber() != 0)
            {
                String name = "";
                int stars = 0;
                foreach (var hotel in this.getListOfHotels())
                {
                    foreach (var room in hotel.getStandartRooms())
                    {
                        if (room.getNumber() == bestStRoom.getNumber())
                        {
                            name = hotel.getName();
                            stars = hotel.getStars();
                        }
                    }
                }
                myObjects.Add(new Room()
                {
                    HotelName = name,
                    Stars = stars,
                    Number = bestStRoom.getNumber(),
                    Rooms = bestStRoom.getRoomsAmount(),
                    Beds = bestStRoom.getBeds(),
                    Windows = bestStRoom.getWindows(),
                    Square = bestStRoom.getSquare(),
                    Appliances = bestStRoom.hasHouseholdAppliances(),
                    Price = bestStRoom.getPrice()
                }); ;
            }
            else if (isReservedStandart == true || bestStRoom.getNumber() == 0)
            {

                List<StandartRoom> stPropositions = this.getStandartProposition();

                foreach (var room in stPropositions)
                {
                   if (dateFrom != null)
            {
                if (dateTo != null)
                {
                    isReservedStandart = room.checkIfReserved(userDateFrom, userDateTo);
                }
                else
                {
                    isReservedStandart = room.checkIfReserved(userDateFrom, userDateFrom);
                }
            }
                    if (isReservedStandart == false)
                    {
                        String name = "";
                        int stars = 0;
                        foreach (var hotel in this.getListOfHotels())
                        {
                            foreach (var room1 in hotel.getStandartRooms())
                            {
                                if (room1.getNumber() == room.getNumber())
                                {
                                    name = hotel.getName();
                                    stars = hotel.getStars();
                                }
                            }
                        }
                        myObjects.Add(new Room()
                        {
                            HotelName = name,
                            Stars = stars,
                            Number = room.getNumber(),
                            Rooms = room.getRoomsAmount(),
                            Beds = room.getBeds(),
                            Windows = room.getWindows(),
                            Square = room.getSquare(),
                            Appliances = room.hasHouseholdAppliances(),
                            Price = room.getPrice()
                        });
                    }
                }

            }


            return myObjects;
        }
        public ObservableCollection<Room> getListOfBestLuxRooms(
              ObservableCollection<Room> myObjects,
            DateTime userDateFrom, DateTime userDateTo,
            DatePicker dateFrom, DatePicker dateTo
            )
        {
           bool isReservedLux = false;
            LuxRoom bestLuxRoom = this.getBestLuxRoom();
            if (dateFrom != null)
            {
                if (dateTo != null)
                {
                    isReservedLux = bestLuxRoom.checkIfReserved(userDateFrom, userDateTo);
                }
                else
                {
                    isReservedLux = bestLuxRoom.checkIfReserved(userDateFrom, userDateFrom);
                }
            }

            if (isReservedLux == false && bestLuxRoom.getNumber() != 0)
            {
                String name = "";
                int stars = 0;
                foreach (var hotel in this.getListOfHotels())
                {
                    foreach (var room in hotel.getLuxRooms())
                    {
                        if (room.getNumber() == bestLuxRoom.getNumber())
                        {
                            name = hotel.getName();
                            stars = hotel.getStars();
                        }
                    }
                }
                myObjects.Add(new Room()
                {
                    HotelName = name,
                    Stars = stars,
                    Number = bestLuxRoom.getNumber(),
                    Rooms = bestLuxRoom.getRoomsAmount(),
                    Beds = bestLuxRoom.getBeds(),
                    Windows = bestLuxRoom.getWindows(),
                    Square = bestLuxRoom.getSquare(),
                    Appliances = bestLuxRoom.hasHouseholdAppliances(),
                    Price = bestLuxRoom.getPrice()
                });
            }
            else if (isReservedLux == true || bestLuxRoom.getNumber() == 0)
            {
                List<LuxRoom> luxPropositions = this.getLuxProposition();
                foreach (var room in luxPropositions)
                {
                    if (dateFrom != null)
                    {
                        if (dateTo != null)
                        {
                            isReservedLux = room.checkIfReserved(userDateFrom, userDateTo);
                        }
                        else
                        {
                            isReservedLux = room.checkIfReserved(userDateFrom, userDateFrom);
                        }
                    }
                    if (isReservedLux == false)
                    {
                        String name = "";
                        int stars = 0;
                        foreach (var hotel in this.getListOfHotels())
                        {
                            foreach (var room1 in hotel.getLuxRooms())
                            {
                                if (room1.getNumber() == room.getNumber())
                                {
                                    name = hotel.getName();
                                    stars = hotel.getStars();
                                }
                            }
                        }
                        myObjects.Add(new Room()
                        {
                            HotelName = name,
                            Stars = stars,
                            Number = room.getNumber(),
                            Rooms = room.getRoomsAmount(),
                            Beds = room.getBeds(),
                            Windows = room.getWindows(),
                            Square = room.getSquare(),
                            Appliances = room.hasHouseholdAppliances(),
                            Price = room.getPrice()
                        });
                    }
                }
            }
            return myObjects;
        }

        }
}
