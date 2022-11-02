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

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            Singleton_AllHotels allHotels = Singleton_AllHotels.AllHotels;
            Singleton_AllCustomers allCustomers = Singleton_AllCustomers.AllCustomers;
            InitializeComponent();
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
            CustomersInfo customersInfo = new CustomersInfo();
            customersInfo.Show();
            this.Close();
           
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            RoomsInfo roomsInfo = new RoomsInfo();
            roomsInfo.Show();
            this.Close();
           
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ReservationWindow reservationW = new ReservationWindow();
            reservationW.Show();
            this.Close();
           
        }

        private void welcomeText_Copy_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }
    }
    
}
