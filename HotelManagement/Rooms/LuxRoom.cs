using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Rooms
{
    public class LuxRoom : StandartRoom
    {
        protected bool hasBalcony = false;
        protected bool hasLivingRoom = false;
        protected bool hasBedRoom = false;
        protected bool hasSofa = false;
        protected bool hasStrongBox = false;

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
        override public void  setRequirements (int stars)
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
