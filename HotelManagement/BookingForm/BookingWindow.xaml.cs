using HotelManagement.Customers;
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

namespace HotelManagement.BookingForm
{
    /// <summary>
    /// Interaction logic for BookingWindow.xaml
    /// </summary>
    public partial class BookingWindow : Window
    {
        public BookingWindow()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, RoutedEventArgs e)
        {
            Singleton_AllCustomers allCustomers = Singleton_AllCustomers.AllCustomers;
            //int age;
            // = System.Convert.ToInt32(ageField.Text);
            Customer customer = new Customer(
                nameField.Text,
                lastnameField.Text,
                emailField.Text,
                phoneField.Text,
                System.Convert.ToInt32(ageField.Text)
                ) ;
            allCustomers.addCustomer(customer);
            this.Hide();
        }
    }
}
