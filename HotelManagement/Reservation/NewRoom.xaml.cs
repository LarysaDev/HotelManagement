using HotelManagement.Rooms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static HotelManagement.Reservation.ReservationWindow;

namespace HotelManagement.Reservation
{
    /// <summary>
    /// Interaction logic for NewRoom.xaml
    /// </summary>
    public partial class NewRoom : Window
    {
        Singleton_AllHotels allHotels = Singleton_AllHotels.AllHotels;
        public NewRoom()
        {
            InitializeComponent();
            
        }

        private void submitBtn_Click(object sender, RoutedEventArgs e)
        {
            if(addToExisting.IsChecked == true)
            {
                Hotel hotel = new Hotel();
                foreach (var hotel1 in allHotels.getListOfHotels()) {
                    if (hotel1.name == nameField.Text) hotel = hotel1;
                 }
                int numberOfRoom = System.Convert.ToInt32(number.Text);
                int rooms = System.Convert.ToInt32(roomsAmount.Text);
                int beds = System.Convert.ToInt32(bedsAmount.Text);
                int windows = System.Convert.ToInt32(windowsAmount.Text);
                double square = System.Convert.ToDouble(square_.Text);
                double price = System.Convert.ToDouble(price_.Text);
                if (number.Text.StartsWith("1"))
                {
                    hotel.addRoom(new StandartRoom( numberOfRoom, rooms, beds, windows, square, price ));
                } else if(number.Text.StartsWith("2"))
            {
                hotel.addLuxRoom(new LuxRoom( numberOfRoom, rooms, beds, windows, square, price));
            }
            } else if(addToNew.IsChecked == true)
            {

            }
            this.Hide();
        }
    }
}
