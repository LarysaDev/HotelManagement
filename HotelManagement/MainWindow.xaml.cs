using HotelManagement.Customers;
using HotelManagement.Reservation;
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
using System.Windows.Navigation;
using System.Windows.Shapes;




namespace HotelManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

   

    public partial class MainWindow : Window
    {

        public void fillHotelsData(Singleton_AllHotels allHotels)
        {

            HashSet<Hotel> hotelSet = new HashSet<Hotel>(6);

            Hotel hotel1 = new Hotel("George", 1);
            Hotel hotel2 = new Hotel("Flower", 2);
            Hotel hotel3 = new Hotel("Willa", 3);
            Hotel hotel4 = new Hotel("Jam", 4);
            Hotel hotel5 = new Hotel("Sonata", 5);
            Hotel hotel6 = new Hotel("Plazma", 3);

            hotelSet.Add(hotel1);
            hotelSet.Add(hotel2);
            hotelSet.Add(hotel3);
            hotelSet.Add(hotel4);
            hotelSet.Add(hotel5);
            hotelSet.Add(hotel6);

            HashSet<StandartRoom> standartRooms1 = new HashSet<StandartRoom>(5);
            HashSet<LuxRoom> luxRooms1 = new HashSet<LuxRoom>(5);
            standartRooms1.Add(new StandartRoom(101, 1, 1, 1, 15.2, 430));
            standartRooms1.Add(new StandartRoom(102, 1, 2, 2, 19.5, 560));
            luxRooms1.Add(new LuxRoom(201, 2, 2, 1, 22.5, 750));
            luxRooms1.Add(new LuxRoom(202, 2, 2, 1, 25.5, 780));

            hotel1.addRooms(standartRooms1);
            hotel1.addLuxRooms(luxRooms1);

            hotel2.addRooms(new HashSet<StandartRoom> {
                new StandartRoom(105, 1, 1, 2, 17, 476),
                new StandartRoom(107, 1, 2, 2, 19, 582)
            });
            hotel2.addLuxRooms(new HashSet<LuxRoom> {
                new LuxRoom(205, 3, 1, 1, 21, 650),
                new LuxRoom(207, 3, 2, 2, 23, 790)
            });

            hotel3.addRooms(new HashSet<StandartRoom> {
                new StandartRoom(106, 1, 1, 2, 17.4, 500),
                new StandartRoom(108, 1, 2, 2, 18, 622)
            });
            hotel3.addLuxRooms(new HashSet<LuxRoom> {
                new LuxRoom(209, 4, 1, 1, 23.5, 700),
                new LuxRoom(210, 4, 2, 2, 25, 799)
            });

            hotel4.addRooms(new HashSet<StandartRoom> {
                new StandartRoom(110, 1, 1, 2, 16, 630),
                new StandartRoom(111, 1, 2, 2, 20, 750.5)
            });
            hotel4.addLuxRooms(new HashSet<LuxRoom> {
                new LuxRoom(211, 4, 1, 1, 23.5, 900),
                new LuxRoom(212, 4, 2, 2, 25, 1099)
            });

            hotel5.addRooms(new HashSet<StandartRoom> {
                new StandartRoom(112, 1, 1, 2, 20, 900),
                new StandartRoom(113, 1, 2, 2, 21, 880.5)
            });
            hotel5.addLuxRooms(new HashSet<LuxRoom> {
                new LuxRoom(213, 4, 1, 1, 29.5, 1000),
                new LuxRoom(214, 4, 2, 2, 30, 1100)
            });

            allHotels.addHotels(hotelSet);
        }

        public MainWindow()
        {
            Singleton_AllHotels allHotels = Singleton_AllHotels.AllHotels;
            InitializeComponent();
            fillHotelsData(allHotels);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            ReservationWindow reservationWindow = new ReservationWindow();
            this.Close();
            reservationWindow.Show();
          
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            CustomersInfo customersInfo = new CustomersInfo();
            customersInfo.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Hide();
            RoomsInfo roomsInfo = new RoomsInfo();
            roomsInfo.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ReservationWindow reservationW = new ReservationWindow();
            reservationW.Show();
        }
    }
    
}
