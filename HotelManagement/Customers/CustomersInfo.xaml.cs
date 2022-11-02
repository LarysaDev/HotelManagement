using HotelManagement.Reservation;
using HotelManagement.Reservation.DataGridRoomClass;
using HotelManagement.Rooms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace HotelManagement.Customers
{

    public partial class CustomersInfo : Window
    {
        Singleton_AllCustomers allCustomers = Singleton_AllCustomers.AllCustomers;
        ObservableCollection<_Customer> myCustomers = new ObservableCollection<_Customer>();

        public CustomersInfo()
        {
            InitializeComponent();
            this.listOfCustomers.ItemsSource = myCustomers;
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
           
        }
        FileManager fileManager = new FileManager();
        private void cm_open_Click(object sender, RoutedEventArgs e)
        {   
            fileManager.openFile();
            this.listOfCustomers.ItemsSource = myCustomers;
        }

        
        private void cm_save_Click(object sender, RoutedEventArgs e)
        {
        }
        private void cm_paste_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.GetText();
        }
      
        private void cm_saveAs_Click(object sender, RoutedEventArgs e)
        {
        }


        private void Button1_Click_1(object sender, RoutedEventArgs e)
        {
            var dg = listOfCustomers;
            switch (customerOption.SelectedIndex)
            {
                case 0:
                    myCustomers.Clear();
                    listOfCustomers.Items.Refresh();
                    Customer customer1 = new Customer();
                    customer1 = allCustomers.getListOfCustomers()[0];
                    foreach(Customer testCustomer in allCustomers.getListOfCustomers())
                    {
                        if(testCustomer.getMaxDaysOfLiving() > customer1.getMaxDaysOfLiving())
                        {
                            customer1 = testCustomer;
                        }

                    }
                    myCustomers.Add(new _Customer()
                    {
                        Name = customer1.getName(),
                        Lastname = customer1.getlastname(),
                        Age = customer1.getAge(),
                        Phone = customer1.getPhone(),
                        Email = customer1.getEmail(),
                        Room = customer1.getListOfReservedRooms()
                    });

                    break;
                case 1:
                    myCustomers.Clear();
                    listOfCustomers.Items.Refresh();
                    Customer customer2 = new Customer();
                    customer2 = allCustomers.getListOfCustomers()[0];
                    foreach (Customer testCustomer in allCustomers.getListOfCustomers())
                    {
                        if (testCustomer.getReservationsCount() > customer2.getReservationsCount())
                        {
                            customer2 = testCustomer;
                        }

                    }
                    myCustomers.Add(new _Customer()
                    {
                        Name = customer2.getName(),
                        Lastname = customer2.getlastname(),
                        Age = customer2.getAge(),
                        Phone = customer2.getPhone(),
                        Email = customer2.getEmail(),
                        Room = customer2.getListOfReservedRooms()
                    });
                    break;
                case 2:
                    myCustomers.Clear();
                    listOfCustomers.Items.Refresh();
                    foreach (Customer customer in allCustomers.getListOfCustomers())
                    {
                        int occurancy = 0;
                        foreach (var item in myCustomers)
                            if (item.Email == customer.getEmail()) occurancy++;
                        if(occurancy == 0)
                        myCustomers.Add(new _Customer()
                        {
                            Name = customer.getName(),
                            Lastname = customer.getlastname(),
                            Age = customer.getAge(),
                            Phone = customer.getPhone(),
                            Email = customer.getEmail(),
                            Room = customer.getListOfReservedRooms()
                        });
                    };
                    break;
            }
            this.listOfCustomers.ItemsSource = myCustomers;
        }
        private void cm_exit(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
            private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ReservationWindow reservationWindow = new ReservationWindow();
            reservationWindow.Show();
        }
    }

}