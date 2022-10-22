using HotelManagement.Customers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Rooms
{
    public class StandartRoom : RoomTemplate
    {
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
        public override void setRequirements(int stars)
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
                    dailyCleaning = true;
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
        public override string getDescription(int stars)
        {
            String description = "Стандартний номер з кількістю зірок: " + stars +" \n";
            if (hasAppliances == true)
                description += "У кімнаті наявна деяка побутова техніка.";
            if(hasOwnBathroom == true)
                description += "Також у кімнаті є окрема ванна кімната.";
             else description += "Також є окрема ванна кімната.";
            if(hasBreakfast == true)
                description += "Передбачений сніданок, що входить у вартість.";
            if(dailyCleaning == true)
                description += "Також можете не турбуватися про чистоту, адже в вартість також входить клінінг.";
            return description;
        }
    }
}
