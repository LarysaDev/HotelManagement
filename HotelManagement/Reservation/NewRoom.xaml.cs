using HotelManagement.Customers;
using HotelManagement.Exceptions;
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
using System.Xml.Linq;
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
            Hotel hotel;
            int numberOfRoom = 0;
            int rooms = 0;
            int beds = 0;
            int windows = 0;
            double square = 0;
            double price = 0;

            try
            {
                if (addToExisting.IsChecked == true || addToNew.IsChecked == true)
                {
                    if (number.Text.Length == 0) throw new EmptyInputException("Number of room");
                    else numberOfRoom = System.Convert.ToInt32(number.Text);

                    if (roomsAmount.Text.Length == 0)
                    {
                        throw new EmptyInputException("Rooms amount");
                    }
                    else rooms = System.Convert.ToInt32(roomsAmount.Text);

                    if (bedsAmount.Text.Length == 0)
                    {
                        throw new EmptyInputException("Beds");
                    }
                    else beds = System.Convert.ToInt32(bedsAmount.Text);

                    if (windowsAmount.Text.Length == 0)
                    {
                        throw new EmptyInputException("Windows");
                    }
                    else windows = System.Convert.ToInt32(windowsAmount.Text);

                    if (square_.Text.Length == 0)
                    {
                        throw new EmptyInputException("Square");
                    }
                    else square = System.Convert.ToDouble(square_.Text);

                    if (price_.Text.Length == 0)
                    {
                        throw new EmptyInputException("Price");
                    }
                    else price = System.Convert.ToDouble(price_.Text);


                    if (addToExisting.IsChecked == true)
                    {
                        hotel = new Hotel();
                        foreach (var hotel1 in allHotels.getListOfHotels())
                        {
                            if (hotel1.name == nameField.Text) hotel = hotel1;
                        }
                        if (number.Text.StartsWith("1"))
                        {
                            hotel.addRoom(new StandartRoom(numberOfRoom, rooms, beds, windows, square, price));
                        }
                        else if (number.Text.StartsWith("2"))
                        {
                            hotel.addLuxRoom(new LuxRoom(numberOfRoom, rooms, beds, windows, square, price));
                        }
                        this.Hide();
                    }
                    else if (addToNew.IsChecked == true)
                    {
                        hotel = new Hotel(nameField.Text, System.Convert.ToInt32(stars_.Text));
                        if (number.Text.StartsWith("1"))
                        {
                            hotel.addRoom(new StandartRoom(numberOfRoom, rooms, beds, windows, square, price));
                        }
                        else if (number.Text.StartsWith("2"))
                        {
                            hotel.addLuxRoom(new LuxRoom(numberOfRoom, rooms, beds, windows, square, price));
                        }
                        allHotels.addHotel(hotel);
                        this.Hide();
                    }
                } else throw new NoCheckedOptionException("add to new or exsisting hotel?");
            }
            catch (EmptyInputException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(NoCheckedOptionException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
