using HotelManagement.Customers;
using HotelManagement.Reservation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Rooms
{
    public class LuxRoom : RoomTemplate
    {

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

        public override void setRequirements(int stars)
        {

            hasBathroom = true;
            dailyCleaning = true;
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
                    hasSofa = true;
                    hasBedRoom = true;
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
        public override string getDescription(int stars)
        {
            String description = "Номер люкс з кількістю зірок: " + stars + " \n";
            description += "У кімнаті наявна деяка побутова техніка, включений клінінг та сніданки.";
            if (hasBalcony == true)
                description += "Також у кімнаті є балкон.";
            if (hasLivingRoom == true)
                description += "Попри те є окрема простора вітальня.";
            if (hasBedRoom == true)
                description += "Окрема спальня - ще одна перевага такої кімнати.";
            if (hasSofa == true)
                description += "У кімнатах є дивани.";
            if (hasStrongBox == true)
                description += "Звісно ж, все задля Вашої безпеки: у кімнаті передбачено сейф.";
            return description;
        }
    }
}
