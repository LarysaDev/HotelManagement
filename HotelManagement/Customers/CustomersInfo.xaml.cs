using HotelManagement.Reservation;
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

namespace HotelManagement.Customers
{
    /// <summary>
    /// Interaction logic for CustomersInfo.xaml
    /// </summary>
    public partial class CustomersInfo : Window
    {
        public CustomersInfo()
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
            this.Hide();
            RoomsInfo roomsInfo = new RoomsInfo();
            roomsInfo.Show();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ReservationWindow reservationWindow = new ReservationWindow();
            reservationWindow.Show();
        }
    }
}
