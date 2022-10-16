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

        public void fillHotelsData(Singleton_AllHotels allHotels, Singleton_AllCustomers allCustomers)
        {
/*
            List<Hotel> hotelSet = new List<Hotel>(6);

            Hotel hotel1 = new Hotel("George", 1);
            Hotel hotel2 = new Hotel("Flower", 2);
            Hotel hotel3 = new Hotel("Willa", 3);
            Hotel hotel4 = new Hotel("Jam", 4);
            Hotel hotel5 = new Hotel("Sonata", 5);

            hotelSet.Add(hotel1);
            hotelSet.Add(hotel2);
            hotelSet.Add(hotel3);
            hotelSet.Add(hotel4);
            hotelSet.Add(hotel5);

            List<StandartRoom> standartRooms1 = new List<StandartRoom>(5);
            List<LuxRoom> luxRooms1 = new List<LuxRoom>(5);
            standartRooms1.Add(new StandartRoom(101, 1, 1, 1, 15.2, 430));
            standartRooms1.Add(new StandartRoom(102, 1, 2, 2, 19.5, 560));
            luxRooms1.Add(new LuxRoom(201, 2, 2, 1, 22.5, 750));
            luxRooms1.Add(new LuxRoom(202, 2, 2, 1, 25.5, 780));

            hotel1.addRooms(standartRooms1);
            hotel1.addLuxRooms(luxRooms1);

            hotel2.addRooms(new List<StandartRoom> {
                new StandartRoom(105, 1, 1, 2, 17, 476),
                new StandartRoom(107, 1, 2, 2, 19, 582)
            });
            hotel2.addLuxRooms(new List<LuxRoom> {
                new LuxRoom(205, 3, 1, 1, 21, 650),
                new LuxRoom(207, 3, 2, 2, 23, 790)
            });

            hotel3.addRooms(new List<StandartRoom> {
                new StandartRoom(106, 1, 1, 2, 17.4, 500),
                new StandartRoom(108, 1, 2, 2, 18, 622)
            });
            hotel3.addLuxRooms(new List<LuxRoom> {
                new LuxRoom(209, 4, 1, 1, 23.5, 700),
                new LuxRoom(210, 4, 2, 2, 25, 799)
            });

            hotel4.addRooms(new List<StandartRoom> {
                new StandartRoom(110, 1, 1, 2, 16, 630),
                new StandartRoom(111, 1, 2, 2, 20, 750.5)
            });
            hotel4.addLuxRooms(new List<LuxRoom> {
                new LuxRoom(211, 4, 1, 1, 23.5, 900),
                new LuxRoom(212, 4, 2, 2, 25, 1099)
            });

            hotel5.addRooms(new List<StandartRoom> {
                new StandartRoom(112, 1, 1, 2, 20, 900),
                new StandartRoom(113, 1, 2, 2, 21, 880.5)
            });
            hotel5.addLuxRooms(new List<LuxRoom> {
                new LuxRoom(213, 4, 1, 1, 29.5, 1000),
                new LuxRoom(214, 4, 2, 2, 30, 1100)
            });

            allHotels.addHotels(hotelSet);

            HashSet<Customer> customerSet = new HashSet<Customer>(6);
            Customer customer1 = new Customer("Nadia", "Prykhodko", "nadia@gmail.com", "+380993354892", 32);
            Customer customer2 = new Customer("Maria", "Melnyk", "maria@gmail.com", "+380633304091", 21);
            Customer customer3 = new Customer("Ivan", "Lisovskyy", "ivan@gmail.com", "+380668812009", 19);
            Customer customer4 = new Customer("Yehor", "Rudyy", "yehor@gmail.com", "+380990000562", 25);
            Customer customer5 = new Customer("Khrystyna", "Khomiak", "khrystyna@gmail.com", "+380991432788", 24);
            Customer customer6 = new Customer("Oleg", "Klymash", "oleg@gmail.com", "+380639698571", 18);
            allCustomers.addCustomer(customer1);
            allCustomers.addCustomer(customer2);
            allCustomers.addCustomer(customer3);
            allCustomers.addCustomer(customer4);
            allCustomers.addCustomer(customer5);
            allCustomers.addCustomer(customer6);

            StandartRoom room1 = standartRooms1[1];
            LuxRoom room2 = hotel4.getLuxRooms()[1];//212
            StandartRoom room3 = hotel3.getStandartRooms()[1];
            LuxRoom room4 = hotel2.getLuxRooms()[0];
            StandartRoom room5 = hotel4.getStandartRooms()[1]; //111

            customer1.reserveStandartRoom(room1, new DateTime(2022, 11, 12), new DateTime(2022, 11, 13));
            customer2.reserveLuxRoom(room2, new DateTime(2022, 11, 20), new DateTime(2022, 11, 26));
            customer3.reserveStandartRoom(room3, new DateTime(2022, 12, 02), new DateTime(2022, 12, 04));
            customer4.reserveLuxRoom(room4, new DateTime(2022, 12, 02), new DateTime(2022, 12, 04));
            customer5.reserveLuxRoom(room4, new DateTime(2022, 12, 02), new DateTime(2022, 12, 04));
            customer6.reserveStandartRoom(room5, new DateTime(2022, 11, 17), new DateTime(2022, 11, 23));
            customer1.reserveStandartRoom(room1, new DateTime(2022, 11, 26), new DateTime(2022, 11, 28));
*/
        }

        public void fillCustomersData(Singleton_AllCustomers allCustomers)
        {
        }
        
        public MainWindow()
        {
            Singleton_AllHotels allHotels = Singleton_AllHotels.AllHotels;
            Singleton_AllCustomers allCustomers = Singleton_AllCustomers.AllCustomers;
            InitializeComponent();
          //  fillHotelsData(allHotels, allCustomers);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            ReservationWindow reservationWindow = new ReservationWindow();
            this.Close();
            reservationWindow.Show();
          
        }
        private void exit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
        private void copy_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(welcomeText.SelectedText);
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

        private void welcomeText_Copy_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }
    }
    
}
