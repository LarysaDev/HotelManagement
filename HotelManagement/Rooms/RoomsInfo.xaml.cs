using HotelManagement.Customers;
using HotelManagement.Reservation;
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

namespace HotelManagement.Rooms
{
    /// <summary>
    /// Interaction logic for RoomsInfo.xaml
    /// </summary>
    public partial class RoomsInfo : Window
    {
        public RoomsInfo()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CustomersInfo customersInfo = new CustomersInfo();
            this.Hide();
            customersInfo.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ReservationWindow reservationWindow = new ReservationWindow();
            this.Hide();
            reservationWindow.Show();
        }
    }
}
