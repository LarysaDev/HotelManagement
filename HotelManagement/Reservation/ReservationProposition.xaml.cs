using HotelManagement.BookingForm;
using HotelManagement.Customers;
using HotelManagement.Exceptions;
using HotelManagement.Reservation.DataGridRoomClass;
using HotelManagement.Rooms;
using System;
using System.Collections.Generic;
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

namespace HotelManagement.Reservation
{
    /// <summary>
    /// Interaction logic for ReservationProposition.xaml
    /// </summary>
    public partial class ReservationProposition : Window
    {
        public ReservationProposition()
        {
            InitializeComponent();
        }
        Singleton_AllCustomers allCustomers = Singleton_AllCustomers.AllCustomers;
        Singleton_AllHotels allHotels = Singleton_AllHotels.AllHotels;
        private void submitDoubleReservation_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                String number = responseField.Text;
                if (number.Length == 0)
                    throw new EmptyInputException("");
            }
            catch (EmptyInputException ex)
            {
                MessageBox.Show(ex.Message);
            }
            BookingWindow bookingForm = new BookingWindow();
            bookingForm.ShowDialog();
            if (bookingForm.Visibility == Visibility.Hidden)
            {
                bookingForm.Close();
                DateTime dateFrom = new DateTime();
                DateTime dateTo = new DateTime();

                DateTime dateFrom1 = new DateTime();
                DateTime dateTo1 = new DateTime();

                //dates for the second hotel
                String[] wordsArray = proppositionField.Text.Split(new string[] { " ", ",", ":" }, StringSplitOptions.None);
                if (wordsArray[0] != "Цей")
                {
                    String[] dateTimesFrom1 = wordsArray[3].Split('.').ToArray();
                    dateFrom = new DateTime(Convert.ToInt32(dateTimesFrom1[2]), Convert.ToInt32(dateTimesFrom1[1]), Convert.ToInt32(dateTimesFrom1[0]));
                    String[] dateTimesTo1 = wordsArray[5].Split('.').ToArray();
                    dateTo = new DateTime(Convert.ToInt32(dateTimesTo1[2]), Convert.ToInt32(dateTimesTo1[1]), Convert.ToInt32(dateTimesTo1[0]));
                }

                //dates for the first hotel
                String[] dateTimesFrom2 = wordsArray[wordsArray.Length - 8].Split('.').ToArray();
                dateFrom1 = new DateTime(Convert.ToInt32(dateTimesFrom2[2]), Convert.ToInt32(dateTimesFrom2[1]), Convert.ToInt32(dateTimesFrom2[0]));
                String[] dateTimesTo2 = wordsArray[wordsArray.Length - 6].Split('.').ToArray();
                dateTo1 = new DateTime(Convert.ToInt32(dateTimesTo2[2]), Convert.ToInt32(dateTimesTo2[1]), Convert.ToInt32(dateTimesTo2[0]));
                //room of additional reservation
                int number2 = Convert.ToInt32(responseField.Text);
                //room for first reservation
                int number1 = Convert.ToInt32(wordsArray[wordsArray.Length - 1]);

                if (wordsArray[0] == "Цей")
                {
                    if ((number2 / 100) == 1)
                    {
                        StandartRoom room = new StandartRoom();
                        foreach (var hotel in allHotels.getListOfHotels())
                        {
                            foreach (var stRoom in hotel.getStandartRooms())
                            {
                                if (stRoom.getNumber() == number2) room = stRoom; break;
                            }
                        }
                        allCustomers.getListOfCustomers()[allCustomers.getListOfCustomers().Count - 1].reserveStandartRoom(room, dateFrom1, dateTo1);
                        MessageBox.Show("The user reserved room " + room.getNumber());
                    }
                    else
                    {
                        LuxRoom room = new LuxRoom();
                        foreach (var hotel in allHotels.getListOfHotels())
                        {
                            foreach (var stRoom in hotel.getLuxRooms())
                            {
                                if (stRoom.getNumber() == number2) room = stRoom; break;
                            }
                        }
                        allCustomers.getListOfCustomers()[allCustomers.getListOfCustomers().Count - 1].reserveLuxRoom(room, dateFrom1, dateTo1);
                        MessageBox.Show("The user reserved room " + room.getNumber());
                    }
                }
                else
                {
                    if ((number1 / 100) == 1)
                    {
                        StandartRoom room = new StandartRoom();
                        foreach (var hotel in allHotels.getListOfHotels())
                        {
                            foreach (var stRoom in hotel.getStandartRooms())
                            {
                                if (stRoom.getNumber() == number1) room = stRoom; break;
                            }
                        }
                        allCustomers.getListOfCustomers()[allCustomers.getListOfCustomers().Count - 1].reserveStandartRoom(room, dateFrom1, dateTo1);
                        MessageBox.Show("The user reserved room " + room.getNumber());
                    }
                    else
                    {
                        LuxRoom room = new LuxRoom();
                        foreach (var hotel in allHotels.getListOfHotels())
                        {
                            foreach (var stRoom in hotel.getLuxRooms())
                            {
                                if (stRoom.getNumber() == number1) room = stRoom; break;
                            }
                        }
                        allCustomers.getListOfCustomers()[allCustomers.getListOfCustomers().Count - 1].reserveLuxRoom(room, dateFrom1, dateTo1);
                        MessageBox.Show("The user reserved room " + room.getNumber());
                    }
                    if ((number2 / 100) == 1)
                    {
                        StandartRoom room1 = new StandartRoom();
                        foreach (var hotel in allHotels.getListOfHotels())
                        {
                            foreach (var stRoom in hotel.getStandartRooms())
                            {
                                if (stRoom.getNumber() == number2) room1 = stRoom; break;
                            }
                        }
                        allCustomers.getListOfCustomers()[allCustomers.getListOfCustomers().Count - 1].reserveStandartRoom(room1, dateFrom, dateTo);
                        MessageBox.Show("The user reserved room " + room1.getNumber());
                    }
                    else
                    {
                        LuxRoom room1 = new LuxRoom();
                        foreach (var hotel in allHotels.getListOfHotels())
                        {
                            foreach (var stRoom in hotel.getLuxRooms())
                            {
                                if (stRoom.getNumber() == number2) room1 = stRoom; break;
                            }
                        }
                        allCustomers.getListOfCustomers()[allCustomers.getListOfCustomers().Count - 1].reserveLuxRoom(room1, dateFrom, dateTo);
                        MessageBox.Show("The user reserved room " + room1.getNumber());
                    }
                }
            }
        }
    }
}
